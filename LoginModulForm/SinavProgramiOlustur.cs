using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginModulForm
{
    public partial class SinavProgramiOlustur : Form
    {
        private int aktifBolumID;
        public SinavProgramiOlustur(int bolumID)
        {
            InitializeComponent();
            this.aktifBolumID = bolumID; // Gelen ID'yi formun her yerinde kullanmak üzere kilitledik
        }
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami; Integrated Security=true";

        private void btn_OtomatikOlustur_Click(object sender, EventArgs e)
        {
            int secilenTakvimID = Convert.ToInt32(cmb_AkademikTakvim.SelectedValue);
            DateTime baslangicTarihi = dtp_Baslangic.Value.Date;
            DateTime bitisTarihi = dtp_Bitis.Value.Date;

            DataBaseClass dbc = new DataBaseClass(connectionString);

            List<int> dersIDListesi = new List<int>();
            List<int> zamanIDListesi = new List<int>();
            List<int> secilenDerslikIDListesi = new List<int>();

            // 1. Havuzları Doldur
            string dersSql = "SELECT DersID FROM Ders WHERE BolumID = @bolumID ORDER BY Kredi DESC";
            DataTable dtDers = dbc.ExecuteQuery(dersSql, new SqlParameter[] { new SqlParameter("@bolumID", this.aktifBolumID) });
            foreach (DataRow row in dtDers.Rows) dersIDListesi.Add(Convert.ToInt32(row["DersID"]));

            string zamanSql = "SELECT ZamanID FROM ZamanDilimi WHERE TakvimID = @takvimID AND Tarih BETWEEN @bas AND @bit";
            DataTable dtZaman = dbc.ExecuteQuery(zamanSql, new SqlParameter[] {
        new SqlParameter("@takvimID", secilenTakvimID),
        new SqlParameter("@bas", baslangicTarihi),
        new SqlParameter("@bit", bitisTarihi)
    });
            foreach (DataRow row in dtZaman.Rows) zamanIDListesi.Add(Convert.ToInt32(row["ZamanID"]));

            foreach (var item in clb_Derslikler.CheckedItems)
            {
                DataRowView row = item as DataRowView;
                if (row != null) secilenDerslikIDListesi.Add(Convert.ToInt32(row["DerslikID"]));
            }

            // 2. HAFIZADA TEST ALGORİTMASIBAŞLIYOR (INSERT YOK!)
            StringBuilder rapor = new StringBuilder();
            rapor.AppendLine($"--- SINAV YERLEŞTİRME TEST RAPORU ---");
            rapor.AppendLine($"Toplam Planlanacak Ders Sayısı: {dersIDListesi.Count}");
            rapor.AppendLine($"Müsait Zaman Dilimi Sayısı: {zamanIDListesi.Count}");
            rapor.AppendLine($"Seçilen Derslik Sayısı: {secilenDerslikIDListesi.Count}\n");

            int yerlestirilenDersSayisi = 0;
            Random rnd = new Random();

            // Sadece tek bir versiyon (Taslak) üzerinden havada simülasyon yapıyoruz
            var karisikZamanlar = zamanIDListesi.OrderBy(x => rnd.Next()).ToList();

            foreach (int dersID in dersIDListesi)
            {
                bool yerlestirildi = false;

                foreach (int zamanID in karisikZamanlar)
                {
                    foreach (int derslikID in secilenDerslikIDListesi)
                    {
                        // Çakışma kontrol motorunu havada test ediyoruz ("TestVersiyonu" ismiyle)
                        if (!CakismaVarMi(dbc, dersID, zamanID, derslikID, "TestVersiyonu"))
                        {
                            // EĞER BURAYA GİRDİYSE: Algoritma bu dersi başarıyla yerleştirebilmiş demektir!
                            rapor.AppendLine($"DersID: {dersID} -> ZamanID: {zamanID}, DerslikID: {derslikID} konumuna BAŞARIYLA yerleşti.");
                            yerlestirilenDersSayisi++;

                            yerlestirildi = true;
                            break;
                        }
                    }
                    if (yerlestirildi) break;
                }

                if (!yerlestirildi)
                {
                    rapor.AppendLine($"⚠️ DersID: {dersID} ÇAKIŞMALARDAN DOLAYI HİÇBİR YERE YERLEŞEMEDİ!");
                }
            }

            rapor.AppendLine($"\nSonuç: {dersIDListesi.Count} dersten {yerlestirilenDersSayisi} tanesi başarıyla planlandı.");

            // 3. RAPORU EKRANA BAS
            MessageBox.Show(rapor.ToString(), "Algoritma Test Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ÇAKIŞMA KONTROL MOTORU
        private bool CakismaVarMi(DataBaseClass dbc, int dersID, int zamanID, int derslikID, string versiyon)
        {
            // A) Salon Dolu mu?
            string sqlDerslik = "SELECT COUNT(*) FROM Sinav WHERE ZamanID = @zid AND DerslikID = @dlid AND ProgramVersiyon = @vers";
            SqlParameter[] p1 = {
        new SqlParameter("@zid", zamanID),
        new SqlParameter("@dlid", derslikID),
        new SqlParameter("@vers", versiyon)
    };
            DataTable dt1 = dbc.ExecuteQuery(sqlDerslik, p1);

            // Satır var mı kontrolü (IndexOutOfRangeException Engelleyici)
            if (dt1 != null && dt1.Rows.Count > 0 && Convert.ToInt32(dt1.Rows[0][0]) > 0)
                return true;

            // B) Aynı sınıf seviyesine (Örn: 3. Sınıflar) aynı saatte başka sınav var mı?
            string sqlSinif = @"SELECT COUNT(*) FROM Sinav s 
                        JOIN Ders d ON s.DersID = d.DersID 
                        WHERE s.ZamanID = @zid AND s.ProgramVersiyon = @vers 
                        AND d.SinifSeviyeID = (SELECT SinifSeviyeID FROM Ders WHERE DersID = @did)";

            // Parametreleri SQL sırasına göre birebir eşliyoruz (Dönüşüm Hatası Engelleyici)
            SqlParameter[] p2 = {
        new SqlParameter("@zid", zamanID),
        new SqlParameter("@vers", versiyon),
        new SqlParameter("@did", dersID)
    };
            DataTable dt2 = dbc.ExecuteQuery(sqlSinif, p2);

            if (dt2 != null && dt2.Rows.Count > 0 && Convert.ToInt32(dt2.Rows[0][0]) > 0)
                return true;

            return false; // Hiçbir çakışma yoksa tertemizdir, yerleştirilebilir!
        }

        // TASLAK BUTONLARI (İncelemek için HocaProgramlar formuna yönlendirir)
        private void btn_Taslak1_Click(object sender, EventArgs e)
        {
            HocaProgramlar hp = new HocaProgramlar(this.aktifBolumID, "Program1");
            hp.Show();
        }
        private void btn_Taslak2_Click(object sender, EventArgs e)
        {
            HocaProgramlar hp = new HocaProgramlar(this.aktifBolumID, "Program2");
            hp.Show();
        }
        private void btn_Taslak3_Click(object sender, EventArgs e)
        {
            HocaProgramlar hp = new HocaProgramlar(this.aktifBolumID, "Program3");
            hp.Show();
        }

        private void SinavProgramiOlustur_Load(object sender, EventArgs e)
        {
            AkademikTakvimleriGetir();
            DerslikleriGetir();
        }

        private void AkademikTakvimleriGetir()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // TakvimID ve Dönem adını çekiyoruz
                string query = "SELECT TakvimID, DonemAdi FROM AkademikTakvim ORDER BY TakvimID DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    da.Fill(dt);

                    // ComboBox'a veriyi bağlıyoruz
                    cmb_AkademikTakvim.DataSource = dt;
                    cmb_AkademikTakvim.DisplayMember = "DonemAdi"; // Ekranda görünecek kısım
                    cmb_AkademikTakvim.ValueMember = "TakvimID";    // Arka planda tutulacak ID değeri
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Akademik takvim yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // 2. CHECKEDLISTBOX'A DERSLİKLERİ ÇEKME
        private void DerslikleriGetir()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Veritabanındaki tüm sınıfları çekiyoruz
                string query = "SELECT DerslikID, DerslikAd FROM Derslik ORDER BY DerslikAd ASC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    da.Fill(dt);

                    // CheckedListBox'ı temizleyip verileri dolduruyoruz
                    clb_Derslikler.DataSource = dt;
                    clb_Derslikler.DisplayMember = "DerslikAd"; // Ekranda kutucuğun yanında yazacak isim
                    clb_Derslikler.ValueMember = "DerslikID";    // İşaretlendiğinde arka planda alacağımız ID
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Derslik listesi yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
