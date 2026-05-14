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
    public partial class DersYonetimi : Form
    {
        public DersYonetimi()
        {
            InitializeComponent();
        }
        int bolum_id;
        int tip_id;
        int seviye_id;
        public int secilenTipId;
        public int secilenDersId;
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";
        private void btn_ekle_Click(object sender, EventArgs e)
        {

            DataBaseClass db = new DataBaseClass(connectionString);
            string d_ad = text_eklead.Text.Trim();
            string b_ad = cmb_eklebolum.Text.Trim();
            string t_ad = cmb_ekletip.Text.Trim();
            string s_no = cmb_ekleseviye.Text.Trim();

            string query = @"
            INSERT INTO Ders
            (DersAdi, BolumID, DersTipiID, SinifSeviyeID, Kredi, SinavSuresi, DersiAlanOgrenciSayisi)
            SELECT 
                @dersadi,
                b.BolumID,
                t.DersTipiID,
                s.SinifSeviyeID,
                @kredi,
                @sure,
                @ogrencisayisi
            FROM Bolum b
            INNER JOIN DersTipi t ON t.TipAd = @tipAd
            INNER JOIN SinifSeviyesi s ON s.SeviyeNo = @seviyeNo AND s.BolumID = b.BolumID
            WHERE b.BolumAd = @bolumAd";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@dersadi", d_ad),
            new SqlParameter("@bolumAd", b_ad),
            new SqlParameter("@tipAd", t_ad),
            new SqlParameter("@seviyeNo", s_no),
            new SqlParameter("@kredi", Convert.ToInt32(nmup_eklekredi.Text)),
            new SqlParameter("@sure", Convert.ToInt32(nmup_eklesure.Text)),
            new SqlParameter("@ogrencisayisi", Convert.ToInt32(nmup_eklesayi.Text))
            };

            int sonuc = db.ExecuteNonQuery(query, parameters);

            if (sonuc > 0)
            {
                MessageBox.Show("Ders başarıyla eklendi.");

                text_eklead.Clear();
                cmb_eklebolum.SelectedIndex = -1;
                cmb_ekletip.SelectedIndex = -1;
                cmb_ekleseviye.Items.Clear();
                nmup_eklekredi.Value=0;
                nmup_eklesure.Value = 0;
                nmup_eklesayi.Value = 0;
            }
            else
            {
                MessageBox.Show("Ders eklenemedi (eşleşen veri yok olabilir).");
            }
        }

        void DersTipleriniYukle()
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            string query = "SELECT TipAd FROM DersTipi";
            DataTable dtTip = db.ExecuteQuery(query);

            cmb_ekletip.DataSource = null; // eskiyi temizle
            cmb_ekletip.DataSource = dtTip;
            cmb_ekletip.DisplayMember = "TipAd";

            cmb_ekletip.SelectedIndex = -1;
        }

        private void DersYonetimi_Load(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            string query = "SELECT BolumAd FROM Bolum";
            string query1 = "SELECT TipAd FROM DersTipi";

            //BÖLÜMLERİ YÜKLE
            DataTable dtBolum = db.ExecuteQuery(query);
            for (int i = 0; i < dtBolum.Rows.Count; i++)
            {
                cmb_eklebolum.Items.Add(dtBolum.Rows[i][0].ToString());
                cmb_guncellebolum.Items.Add(dtBolum.Rows[i][0].ToString());
            }

            //DERS TİPİ YÜKLE

            DataTable dtTip = db.ExecuteQuery(query1);
            for (int i = 0; i < dtTip.Rows.Count; i++)
            {
                cmb_ekletip.Items.Add(dtTip.Rows[i][0].ToString());
                cmb_guncelletip.Items.Add(dtTip.Rows[i][0].ToString());

            }
            DersTipleriniYukle();

            ToolTip mesaj = new ToolTip();
            mesaj.ToolTipTitle = "Arama";
            mesaj.ToolTipIcon = ToolTipIcon.Info;
            mesaj.ShowAlways = true;
            mesaj.SetToolTip(text_tipguncelle, "Arama için F4 tuşuna basınız");
            mesaj.SetToolTip(text_tipsil, "Arama için F4 tuşuna basınız");
            mesaj.SetToolTip(text_silad, "Arama için F4 tuşuna basınız");
            mesaj.SetToolTip(text_guncellead, "Arama için F4 tuşuna basınız");

        }

        private void cmb_eklebolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_eklebolum.SelectedIndex == -1)
                return;
            DataBaseClass db = new DataBaseClass(connectionString);
            string b_ad = cmb_eklebolum.Text.Trim();
            string query1 = "select BolumID from Bolum where BolumAd=@B_Ad";
            SqlParameter[] parameters = new SqlParameter[] {
             new SqlParameter("@B_Ad", b_ad),
            };
            DataTable dt1 = db.ExecuteQuery(query1, parameters);

            if (dt1.Rows.Count == 0)
                return;
            bolum_id =Convert.ToInt32(dt1.Rows[0][0]);

            cmb_ekleseviye.Items.Clear();

            string querySeviye = "SELECT SeviyeNo FROM SinifSeviyesi WHERE BolumID=@bid";
            SqlParameter[] p = {
                new SqlParameter("@bid", bolum_id)
            };

            DataTable dtSeviye = db.ExecuteQuery(querySeviye, p);

            for (int i = 0; i < dtSeviye.Rows.Count; i++)
            {
                cmb_ekleseviye.Items.Add(dtSeviye.Rows[i][0].ToString());
            }
        }

        private void btn_tipekle_Click(object sender, EventArgs e)
        {
            DataBaseClass db=new DataBaseClass(connectionString);
            string t_ad_ek = text_tipekle.Text.Trim();
            string query = "INSERT INTO DersTipi(TipAd) VALUES (@tadi)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tadi", t_ad_ek)
            };
            int sonuc = db.ExecuteNonQuery(query, parameters);
            if (sonuc > 0)
            {
                MessageBox.Show("Ders Tipi Eklendi");
                text_tipekle.Clear();

                DersTipleriniYukle();
            }
            else
            {
                MessageBox.Show("Hata");
            }

        }

        private void cmb_ekletip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ekletip.SelectedIndex == -1)
                return;
            DataBaseClass db = new DataBaseClass(connectionString);
            string tad = cmb_ekletip.Text.Trim();
            string query1 = "SELECT DersTipiID FROM DersTipi WHERE TipAd=@t_ad";
            SqlParameter[] parameters = new SqlParameter[] {
             new SqlParameter("@t_ad", tad)
            };
            DataTable dt1 = db.ExecuteQuery(query1, parameters);
            if (dt1.Rows.Count > 0)
            {
                tip_id = Convert.ToInt32(dt1.Rows[0][0]);
            }
        }

        private void cmb_ekleseviye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_eklebolum.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce bölüm seçiniz.");
                return;
            }

            if (cmb_ekleseviye.SelectedIndex == -1)
                return;

            DataBaseClass db = new DataBaseClass(connectionString);
            string sno = cmb_ekleseviye.Text.Trim();
            string query3 = "SELECT SinifSeviyeID FROM SinifSeviyesi WHERE SeviyeNo=@s_no AND BolumID=@bid";
            SqlParameter[] parameters = new SqlParameter[] {
             new SqlParameter("s_no", sno),
             new SqlParameter("@bid", bolum_id)
            };
            DataTable dt2 = db.ExecuteQuery(query3, parameters);
            if (dt2.Rows.Count > 0)
            {
                seviye_id = Convert.ToInt32(dt2.Rows[0][0]);
            }

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            string query = @"
            SELECT 
                d.DersAdi,
                b.BolumAd,
                t.TipAd,
                s.SeviyeNo,
                d.Kredi,
                d.SinavSuresi,
                d.DersiAlanOgrenciSayisi
            FROM Ders d
            INNER JOIN Bolum b ON d.BolumID = b.BolumID
            INNER JOIN DersTipi t ON d.DersTipiID = t.DersTipiID
            INNER JOIN SinifSeviyesi s ON d.SinifSeviyeID = s.SinifSeviyeID";
            DataTable dt = db.ExecuteQuery(query);
            dataGridView_derslistele.DataSource = dt;
            dataGridView_derslistele.Columns["DersAdi"].HeaderText = "Ders Adı";
            dataGridView_derslistele.Columns["BolumAd"].HeaderText = "Bölüm Adı";
            dataGridView_derslistele.Columns["TipAd"].HeaderText = "Ders Tipi";
            dataGridView_derslistele.Columns["SeviyeNo"].HeaderText = "Sınıf Seviyesi";
            dataGridView_derslistele.Columns["SinavSuresi"].HeaderText = "Dersin Sınav Süresi";
            dataGridView_derslistele.Columns["DersiAlanOgrenciSayisi"].HeaderText = "Dersi Alan Öğrenci Sayısı";
        }

        private void label_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            this.Close();
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();

        }

        private void label26_Click(object sender, EventArgs e)
        {
            this.Close();
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            this.Close();
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            this.Close();
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
        }

        private void btn_tipguncelle_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            DialogResult mesaj = MessageBox.Show(" Bu kaydı güncellemek stediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.Yes)
            {
                string t_ad = text_tipguncelle.Text.Trim();
                string query = "UPDATE DersTipi SET TipAd=@t_ad WHERE DersTipiID=@t_id";
                SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@t_ad", t_ad),
                new SqlParameter("@t_id", secilenTipId)
            };
                int sonuc = db.ExecuteNonQuery(query, parameters);
                if (sonuc > 0)
                {
                    MessageBox.Show("Ders Tipi Güncellendi");
                    text_tipguncelle.Clear();

                    DersTipleriniYukle();
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }           
        }

        private void text_tipguncelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                DersTipiArama dfrm = new DersTipiArama();
                dfrm.islemTipi = "guncelle";
                dfrm.Show();
                this.Hide();
            }
        }

        private void text_tipsil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                DersTipiArama dfrm = new DersTipiArama();
                dfrm.islemTipi = "sil";
                dfrm.Show();
                this.Hide();
            }
        }

        private void btn_tipsil_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            DialogResult mesaj = MessageBox.Show(" Bu kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.Yes)
            { 
                string t_ad = text_tipsil.Text.Trim();
                string query = "DELETE FROM DersTipi WHERE TipAd=@t_ad";
                SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@t_ad", t_ad)
            };
                int sonuc = db.ExecuteNonQuery(query, parameters);
                if (sonuc > 0)
                {
                    MessageBox.Show("Ders Tipi Silindi");
                    text_tipsil.Clear();

                    DersTipleriniYukle();
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            DialogResult mesaj = MessageBox.Show(
                "Bu dersi silmek istediğinize emin misiniz?",
                "Uyarı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (mesaj == DialogResult.Yes)
            {
                string d_ad = text_silad.Text.Trim();
                string b_ad = text_silbolum.Text.Trim();
                string t_ad = text_siltip.Text.Trim();
                string s_no = text_silseviye.Text.Trim();

                string query = @"
                DELETE d
                FROM Ders d
                INNER JOIN Bolum b 
                  ON d.BolumID = b.BolumID
                INNER JOIN DersTipi dt
                  ON d.DersTipiID = dt.DersTipiID
                INNER JOIN SinifSeviyesi ss
                  ON d.SinifSeviyeID = ss.SinifSeviyeID
                WHERE d.DersAdi = @dad
                AND b.BolumAd = @bad
                AND dt.TipAd = @tad
                AND ss.SeviyeNo = @sno";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@dad", d_ad),
                    new SqlParameter("@bad", b_ad),
                    new SqlParameter("@tad", t_ad),
                    new SqlParameter("@sno", s_no)
                };

                int sonuc = db.ExecuteNonQuery(query, parameters);

                if (sonuc > 0)
                {
                    MessageBox.Show("Ders silindi");

                    text_silad.Clear();
                    text_silbolum.Clear();
                    text_siltip.Clear();
                    text_silseviye.Clear();
                    text_silkredi.Clear();
                    text_silsure.Clear();
                    text_silmevcud.Clear();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız");
                }
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            DialogResult mesaj = MessageBox.Show(
                "Bu dersi güncellemek istediğinize emin misiniz?",
                "Uyarı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (mesaj == DialogResult.Yes)
            {
                string d_ad = text_guncellead.Text.Trim();
                string b_ad = cmb_guncellebolum.Text.Trim();
                string t_ad = cmb_guncelletip.Text.Trim();
                string s_no = cmb_guncelleseviye.Text.Trim();

                int kredi = (int)nmup_guncellekredi.Value;
                int sure = (int)nmup_guncellesure.Value;
                int ogrsayi = (int)nmup_guncelleogrsayisi.Value;

                string query = @"
                UPDATE Ders
                SET 
                   DersAdi = @ad,
                   BolumID = @bolumId,
                   DersTipiID = @tipId,
                   SinifSeviyeID = @seviyeId,
                   Kredi = @kredi,
                   SinavSuresi = @sure,
                   DersiAlanOgrenciSayisi = @ogr
                WHERE DersID = @id";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ad", text_guncellead.Text.Trim()),
                    new SqlParameter("@bolumId", bolum_id),
                    new SqlParameter("@tipId", tip_id),
                    new SqlParameter("@seviyeId", seviye_id),

                    new SqlParameter("@kredi", (int)nmup_guncellekredi.Value),
                    new SqlParameter("@sure", (int)nmup_guncellesure.Value),
                    new SqlParameter("@ogr", (int)nmup_guncelleogrsayisi.Value),
                    new SqlParameter("@id", secilenDersId)
                };

                int sonuc = db.ExecuteNonQuery(query, parameters);

                if (sonuc > 0)
                {
                    MessageBox.Show("Ders güncellendi");
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız");
                }
            }
        }

        private void text_guncellead_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                DersArama darm = new DersArama();
                darm.islemTipi = "guncelle";
                darm.Show();
                this.Hide();
            }

        }

        private void text_silad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                DersArama darm = new DersArama();
                darm.islemTipi = "sil";
                darm.Show();
                this.Hide();
            }
        }

        private void cmb_guncellebolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_guncellebolum.SelectedIndex == -1)
                return;

            DataBaseClass db = new DataBaseClass(connectionString);

            string b_ad = cmb_guncellebolum.Text.Trim();

            string query = "SELECT BolumID FROM Bolum WHERE BolumAd=@ad";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ad", b_ad)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                bolum_id = Convert.ToInt32(dt.Rows[0][0]);
            }

            cmb_guncelleseviye.Items.Clear();

            string query2 = "SELECT SeviyeNo FROM SinifSeviyesi WHERE BolumID=@id";

            SqlParameter[] p =
            {
                new SqlParameter("@id", bolum_id)
            };

            DataTable dt2 = db.ExecuteQuery(query2, p);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cmb_guncelleseviye.Items.Add(dt2.Rows[i][0].ToString());
            }
        }

        private void cmb_guncelletip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_guncelletip.SelectedIndex == -1)
                return;

            DataBaseClass db = new DataBaseClass(connectionString);

            string t_ad = cmb_guncelletip.Text.Trim();

            string query = "SELECT DersTipiID FROM DersTipi WHERE TipAd=@ad";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ad", t_ad)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                tip_id = Convert.ToInt32(dt.Rows[0][0]);
            }
        }

        private void cmb_guncelleseviye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_guncelleseviye.SelectedIndex == -1)
                return;

            DataBaseClass db = new DataBaseClass(connectionString);

            string sno = cmb_guncelleseviye.Text.Trim();

            string query = @"

            SELECT SinifSeviyeID 
            FROM SinifSeviyesi 
            WHERE SeviyeNo=@s AND BolumID=@bid";

            SqlParameter[] parameters =
            {
                new SqlParameter("@s", sno),
                new SqlParameter("@bid", bolum_id)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                seviye_id = Convert.ToInt32(dt.Rows[0][0]);
            }
        }
    }
}
