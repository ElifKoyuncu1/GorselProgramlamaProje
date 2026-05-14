using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginModulForm
{
    public partial class TakvimZamanDilimiAraForm : Form
    {
        string connectionString = @"Data Source=192.168.1.197,1433;Initial Catalog=SinavProgrami;User ID=sas ;Password=123;TrustServerCertificate=True";

        public int SecilenZamanID { get; private set; }
        public int SecilenTakvimID { get; private set; }
        public DateTime SecilenTarih { get; private set; }
        public TimeSpan SecilenBaslangicSaat { get; private set; }
        public TimeSpan SecilenBitisSaat { get; private set; }

        public TakvimZamanDilimiAraForm()
        {
            InitializeComponent();

            btnAra.Click -= btnAra_Click;
            btnAra.Click += btnAra_Click;

            GuncelleButonunuGizle();

            dtpAraTarih.ShowCheckBox = true;
            dtpAraTarih.Checked = false;

            DonemleriYukle();
        }

        private void GuncelleButonunuGizle()
        {
            Control[] bulunanKontroller = this.Controls.Find("btnGuncelle", true);

            foreach (Control kontrol in bulunanKontroller)
            {
                kontrol.Visible = false;
                kontrol.Enabled = false;
            }
        }

        private void DonemleriYukle()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();

                    string sorgu = @"
                        SELECT 
                            TakvimID,
                            DonemAdi + ' - ' + SinavTipi AS DonemTipi
                        FROM AkademikTakvim
                        ORDER BY DonemAdi, SinavTipi";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbAraDonemTipi.DataSource = dt;
                    cmbAraDonemTipi.DisplayMember = "DonemTipi";
                    cmbAraDonemTipi.ValueMember = "TakvimID";
                    cmbAraDonemTipi.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbAraDonemTipi.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dönem bilgileri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private int SecilenTakvimIDGetir()
        {
            if (cmbAraDonemTipi.SelectedIndex == -1)
                return 0;

            if (cmbAraDonemTipi.SelectedValue == null)
                return 0;

            int takvimID;

            if (int.TryParse(cmbAraDonemTipi.SelectedValue.ToString(), out takvimID))
                return takvimID;

            return 0;
        }

        private bool SaatKontrol(string saat, out TimeSpan sonuc)
        {
            sonuc = TimeSpan.Zero;

            return TimeSpan.TryParseExact(
                saat,
                @"hh\:mm",
                CultureInfo.InvariantCulture,
                out sonuc);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int takvimID = SecilenTakvimIDGetir();

            bool donemSecildi = takvimID != 0;
            bool tarihSecildi = dtpAraTarih.Checked;
            bool baslangicGirildi = mtxAraBaslangic.MaskCompleted;
            bool bitisGirildi = mtxAraBitis.MaskCompleted;

            if (!donemSecildi && !tarihSecildi && !baslangicGirildi && !bitisGirildi)
            {
                MessageBox.Show("Arama yapmak için en az bir bilgi giriniz.");
                return;
            }

            TimeSpan baslangicSaat = TimeSpan.Zero;
            TimeSpan bitisSaat = TimeSpan.Zero;

            if (baslangicGirildi)
            {
                if (!SaatKontrol(mtxAraBaslangic.Text, out baslangicSaat))
                {
                    MessageBox.Show("Başlangıç saati geçerli değil. Örnek: 09:00");
                    return;
                }
            }

            if (bitisGirildi)
            {
                if (!SaatKontrol(mtxAraBitis.Text, out bitisSaat))
                {
                    MessageBox.Show("Bitiş saati geçerli değil. Örnek: 10:00");
                    return;
                }
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();

                    List<string> kosullar = new List<string>();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = baglanti;

                    if (donemSecildi)
                    {
                        kosullar.Add("TakvimID = @takvimID");
                        komut.Parameters.AddWithValue("@takvimID", takvimID);
                    }

                    if (tarihSecildi)
                    {
                        kosullar.Add("Tarih = @tarih");
                        komut.Parameters.AddWithValue("@tarih", dtpAraTarih.Value.Date);
                    }

                    if (baslangicGirildi)
                    {
                        kosullar.Add("BaslangicSaat = @baslangicSaat");
                        komut.Parameters.AddWithValue("@baslangicSaat", baslangicSaat);
                    }

                    if (bitisGirildi)
                    {
                        kosullar.Add("BitisSaat = @bitisSaat");
                        komut.Parameters.AddWithValue("@bitisSaat", bitisSaat);
                    }

                    string sorgu = @"
                        SELECT TOP 1
                            ZamanID,
                            TakvimID,
                            Tarih,
                            BaslangicSaat,
                            BitisSaat
                        FROM ZamanDilimi
                        WHERE " + string.Join(" AND ", kosullar) + @"
                        ORDER BY Tarih, BaslangicSaat";

                    komut.CommandText = sorgu;

                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            SecilenZamanID = Convert.ToInt32(dr["ZamanID"]);
                            SecilenTakvimID = Convert.ToInt32(dr["TakvimID"]);
                            SecilenTarih = Convert.ToDateTime(dr["Tarih"]);
                            SecilenBaslangicSaat = (TimeSpan)dr["BaslangicSaat"];
                            SecilenBitisSaat = (TimeSpan)dr["BitisSaat"];

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            SecilenZamanID = 0;
                            SecilenTakvimID = 0;

                            MessageBox.Show("Girilen bilgiye uygun kayıt bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama sırasında hata oluştu: " + ex.Message);
            }
        }
    }
}
