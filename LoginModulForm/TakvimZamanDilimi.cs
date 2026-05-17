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
    public partial class TakvimZamanDilimi : Form
    {
       

        public TakvimZamanDilimi()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";
        public int secilenZamanID;

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            if (cmb_dnm_Ekle.SelectedIndex == -1)
            {
                MessageBox.Show("Akademik takvim seç.");
                return;
            }

            TimeSpan bas = dtp_basekle.Value.TimeOfDay;
            TimeSpan bit = dtp_bitekle.Value.TimeOfDay;

            if (bas >= bit)
            {
                MessageBox.Show("Başlangıç saati bitişten küçük olmalı.");
                return;
            }

            int takvimID = Convert.ToInt32(cmb_dnm_Ekle.SelectedValue);
            DateTime tarih = dtpEkle.Value.Date;

            string kontrolQuery = @"
            SELECT 1 FROM ZamanDilimi
            WHERE TakvimID=@tid
            AND Tarih=@tarih
            AND (@bas < BitisSaat AND @bit > BaslangicSaat)";

            SqlParameter[] kontrolParams =
            {
                new SqlParameter("@tid", takvimID),
                new SqlParameter("@tarih", tarih),
                new SqlParameter("@bas", bas),
                new SqlParameter("@bit", bit)
            };

            DataTable kontrol = db.ExecuteQuery(kontrolQuery, kontrolParams);

            if (kontrol.Rows.Count > 0)
            {
                MessageBox.Show("Bu saat aralığı çakışıyor.");
                return;
            }

            string query = @"
            INSERT INTO ZamanDilimi (TakvimID, Tarih, BaslangicSaat, BitisSaat)
            VALUES (@tid, @tarih, @bas, @bit)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@tid", takvimID),
                new SqlParameter("@tarih", tarih),
                new SqlParameter("@bas", bas),
                new SqlParameter("@bit", bit)
            };

            int sonuc = db.ExecuteNonQuery(query, parameters);

            MessageBox.Show(sonuc > 0 ? "Eklendi" : "Hata");
        }

        private void TakvimZamanDilimi_Load(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            string query = @"
            SELECT 
                TakvimID,
                DonemAdi + ' - ' + SinavTipi AS DonemTipi
            FROM AkademikTakvim";

            DataTable dt = db.ExecuteQuery(query);

            cmb_dnm_Ekle.DataSource = dt;
            cmb_dnm_Ekle.DisplayMember = "DonemTipi";
            cmb_dnm_Ekle.ValueMember = "TakvimID";
            cmb_dnm_Ekle.SelectedIndex = -1;

            cmb_guncelle.DataSource = dt.Copy();
            cmb_guncelle.DisplayMember = "DonemTipi";
            cmb_guncelle.ValueMember = "TakvimID";
            cmb_guncelle.SelectedIndex = -1;


            ToolTip mesaj = new ToolTip();
            mesaj.ToolTipTitle = "Arama";
            mesaj.ToolTipIcon = ToolTipIcon.Info;
            mesaj.ShowAlways = true;
            mesaj.SetToolTip(text_dnmsil, "Arama için F4 tuşuna basınız");
            mesaj.SetToolTip(cmb_guncelle, "Arama için F4 tuşuna basınız");
        }

        private void text_dnmsil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                TakvimZamanDilimiAraForm tfrm = new TakvimZamanDilimiAraForm();
                tfrm.islemTipi = "sil";
                tfrm.Show();
                this.Hide();
            }
        }

        private void cmb_guncelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                TakvimZamanDilimiAraForm tfrm = new TakvimZamanDilimiAraForm();
                tfrm.islemTipi = "guncelle";
                tfrm.Show();
                this.Hide();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            DialogResult mesaj = MessageBox.Show(
                "Bu kaydı güncellemek istediğinize emin misiniz?",
                "Uyarı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (mesaj == DialogResult.Yes)
            {
                if (cmb_guncelle.SelectedIndex == -1)
                {
                    MessageBox.Show("Akademik takvim seçiniz.");
                    return;
                }

                int takvimID =
                Convert.ToInt32(cmb_guncelle.SelectedValue);

                DateTime tarih =
                dtp_guncelle.Value.Date;

                TimeSpan bas =
                dtp_basguncelle.Value.TimeOfDay;

                TimeSpan bit =
                dtp_bitguncelle.Value.TimeOfDay;

                if (bas >= bit)
                {
                    MessageBox.Show(
                    "Başlangıç saati bitiş saatinden küçük olmalıdır.");

                    return;
                }

                // ÇAKIŞMA KONTROLÜ
                string kontrolQuery = @"
                SELECT 1
                FROM ZamanDilimi
                WHERE TakvimID = @tid
                AND Tarih = @tarih
                AND (@bas < BitisSaat AND @bit > BaslangicSaat)
                AND ZamanID != @id";

                SqlParameter[] kontrolParams =
                {
                    new SqlParameter("@tid", takvimID),
                    new SqlParameter("@tarih", tarih),
                    new SqlParameter("@bas", bas),
                    new SqlParameter("@bit", bit),
                    new SqlParameter("@id", secilenZamanID)
                };

                DataTable kontrol =
                db.ExecuteQuery(kontrolQuery, kontrolParams);

                if (kontrol.Rows.Count > 0)
                {
                    MessageBox.Show(
                    "Bu saat aralığı başka bir kayıtla çakışıyor.");

                    return;
                }

                string query = @"
                UPDATE ZamanDilimi
                SET
                   TakvimID = @tid,
                   Tarih = @tarih,
                   BaslangicSaat = @bas,
                   BitisSaat = @bit
                WHERE ZamanID = @id";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@tid", takvimID),
                    new SqlParameter("@tarih", tarih),
                    new SqlParameter("@bas", bas),
                    new SqlParameter("@bit", bit),
                    new SqlParameter("@id", secilenZamanID)
                };

                int sonuc =
                db.ExecuteNonQuery(query, parameters);

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız.");
                }
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi iptal edildi.");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            DialogResult mesaj = MessageBox.Show(
                "Bu zaman dilimini silmek istediğinize emin misiniz?",
                "Uyarı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (mesaj == DialogResult.Yes)
            {
                string query = @"DELETE FROM ZamanDilimi WHERE ZamanID = @id";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@id", secilenZamanID)
                };

                int sonuc = db.ExecuteNonQuery(query, parameters);

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt silindi.");

                    text_dnmsil.Clear();
                    text_trhsil.Clear();
                    text_bassil.Clear();
                    text_bitsil.Clear();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız.");
                }
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi.");
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            string query = @"SELECT 
                                ZamanID,
                                DonemAdi + ' - ' + SinavTipi AS DonemTipi,
                                Tarih,
                                BaslangicSaat,
                                BitisSaat
                            FROM ZamanDilimi
                            INNER JOIN AkademikTakvim ON ZamanDilimi.TakvimID = AkademikTakvim.TakvimID";
            DataTable dt = db.ExecuteQuery(query);
            dataGridView2.DataSource = dt;

        }

        private void label15_Click(object sender, EventArgs e)
        {
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
            this.Hide();
        }
    }
}
