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
        

        void DersTipleriniYukle()
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            string query = "SELECT DersTipiID, TipAd FROM DersTipi";

            DataTable dtTip = db.ExecuteQuery(query);

            cmb_ekletip.DataSource = dtTip;
            cmb_ekletip.DisplayMember = "TipAd";
            cmb_ekletip.ValueMember = "DersTipiID";

            cmb_ekletip.SelectedIndex = -1;
        }

        private void DersYonetimi_Load(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            // BÖLÜM
            string queryBolum = "SELECT BolumID, BolumAd FROM Bolum";
            DataTable dtBolum = db.ExecuteQuery(queryBolum);

            cmb_eklebolum.DataSource = dtBolum;
            cmb_eklebolum.DisplayMember = "BolumAd";
            cmb_eklebolum.ValueMember = "BolumID";

            cmb_guncellebolum.DataSource = dtBolum.Copy();
            cmb_guncellebolum.DisplayMember = "BolumAd";
            cmb_guncellebolum.ValueMember = "BolumID";


            // DERS TİPİ
            string queryTip = "SELECT DersTipiID, TipAd FROM DersTipi";
            DataTable dtTip = db.ExecuteQuery(queryTip);

            cmb_ekletip.DataSource = dtTip;
            cmb_ekletip.DisplayMember = "TipAd";
            cmb_ekletip.ValueMember = "DersTipiID";

            cmb_guncelletip.DataSource = dtTip.Copy();
            cmb_guncelletip.DisplayMember = "TipAd";
            cmb_guncelletip.ValueMember = "DersTipiID";
            cmb_ekletip.SelectedIndex = -1;
            cmb_eklebolum.SelectedIndex = -1;

            ToolTip mesaj = new ToolTip();
            mesaj.ToolTipTitle = "Arama";
            mesaj.ToolTipIcon = ToolTipIcon.Info;
            mesaj.ShowAlways = true;
            mesaj.SetToolTip(text_tipguncelle, "Arama için F4 tuşuna basınız");
            mesaj.SetToolTip(text_tipsil, "Arama için F4 tuşuna basınız");
            mesaj.SetToolTip(text_silad, "Arama için F4 tuşuna basınız");
            mesaj.SetToolTip(text_guncellead, "Arama için F4 tuşuna basınız");

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (cmb_eklebolum.SelectedValue == null ||
                cmb_ekletip.SelectedValue == null ||
                cmb_ekleseviye.SelectedValue == null)
            {
                MessageBox.Show("Tüm seçimleri yapınız.");
                return;
            }

            DataBaseClass db = new DataBaseClass(connectionString);
            string dersAd = text_eklead.Text.Trim();
            int bolumID = Convert.ToInt32(cmb_eklebolum.SelectedValue);
            int tipID = Convert.ToInt32(cmb_ekletip.SelectedValue);
            int s_no = Convert.ToInt32(cmb_ekleseviye.SelectedValue);

            string query = @"
            INSERT INTO Ders
            (
                DersAdi,
                BolumID,
                DersTipiID,
                SinifSeviyeID,
                Kredi,
                SinavSuresi,
                DersiAlanOgrenciSayisi
            )
            VALUES
            (
                @ad,
                @bid,
                @tid,
                @sid,
                @kredi,
                @sure,
                @ogr
            )";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ad", dersAd),
            new SqlParameter("@bid", bolumID),
            new SqlParameter("@tid", tipID),
            new SqlParameter("@sid", s_no),
            new SqlParameter("@kredi", (int)nmup_eklekredi.Value),
            new SqlParameter("@sure", (int)nmup_eklesure.Value),
            new SqlParameter("@ogr", (int)nmup_eklesayi.Value)
            };

            int sonuc = db.ExecuteNonQuery(query, parameters);

            if (sonuc > 0)
            {
                MessageBox.Show("Ders başarıyla eklendi.");

                text_eklead.Clear();
                cmb_eklebolum.SelectedIndex = -1;
                cmb_ekletip.SelectedIndex = -1;
                nmup_eklekredi.Value = 0;
                nmup_eklesure.Value = 0;
                nmup_eklesayi.Value = 0;
            }
            else
            {
                MessageBox.Show("Ders eklenemedi (eşleşen veri yok olabilir).");
            }
        }

        private void cmb_eklebolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_eklebolum.SelectedValue == null) return;
            if (cmb_eklebolum.SelectedValue is DataRowView) return;

            bolum_id = Convert.ToInt32(cmb_eklebolum.SelectedValue);

            DataBaseClass db = new DataBaseClass(connectionString);

            DataTable dt = db.ExecuteQuery(
                "SELECT SinifSeviyeID, SeviyeNo FROM SinifSeviyesi WHERE BolumID=@id",
                new SqlParameter[] { new SqlParameter("@id", bolum_id) }
            );

            cmb_ekleseviye.DataSource = dt;
            cmb_ekleseviye.DisplayMember = "SeviyeNo";
            cmb_ekleseviye.ValueMember = "SinifSeviyeID";
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
                string query = "DELETE FROM Ders WHERE DersID = @id";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@id", secilenDersId)
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
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi");
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
                string dersAd = text_guncellead.Text.Trim();
                int bolumId = Convert.ToInt32(cmb_guncellebolum.SelectedValue);
                int tipId = Convert.ToInt32(cmb_guncelletip.SelectedValue);
                int seviyeId = Convert.ToInt32(cmb_guncelleseviye.SelectedValue);
                int kredi = (int)nmup_guncellekredi.Value;
                int sure = (int)nmup_guncellesure.Value;
                int ogrsayi = (int)nmup_guncelleogrsayisi.Value;

                string query = @"
                UPDATE Ders
                SET 
                   DersAdi = @ad,
                   BolumID = @bid,
                   DersTipiID = @tid,
                   SinifSeviyeID = @sid,
                   Kredi = @kredi,
                   SinavSuresi = @sure,
                   DersiAlanOgrenciSayisi = @ogr
                WHERE DersID = @id";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ad", dersAd),
                    new SqlParameter("@bid", bolumId),
                    new SqlParameter("@tid", tipId),
                    new SqlParameter("@sid", seviyeId),

                    new SqlParameter("@kredi", kredi),
                    new SqlParameter("@sure", sure),
                    new SqlParameter("@ogr", ogrsayi),
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
            else
            {
                MessageBox.Show("Güncelleme işlemi iptal edildi");

            }
        }

        private void cmb_guncellebolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_guncellebolum.SelectedValue == null)
                return;

            if (!int.TryParse(cmb_guncellebolum.SelectedValue.ToString(), out bolum_id))
                return;

            DataBaseClass db = new DataBaseClass(connectionString);

            string query = @"
            SELECT 
               SinifSeviyeID,
               SeviyeNo
            FROM SinifSeviyesi
            WHERE BolumID=@id";

            SqlParameter[] p =
            {
                new SqlParameter("@id", bolum_id)
            };

            DataTable dt = db.ExecuteQuery(query, p);

            cmb_guncelleseviye.DataSource = dt;
            cmb_guncelleseviye.DisplayMember = "SeviyeNo";
            cmb_guncelleseviye.ValueMember = "SinifSeviyeID";
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

        

        

        
        

        

        private void cmb_guncelletip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_guncelletip.SelectedValue == null)
                return;

            if (cmb_guncelletip.SelectedValue is DataRowView)
                return;

            if (int.TryParse(cmb_guncelletip.SelectedValue.ToString(), out int result))
            {
                tip_id = result;
            }
        }

        private void cmb_guncelleseviye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_guncelleseviye.SelectedValue == null) return;
            if (cmb_guncelleseviye.SelectedValue is DataRowView) return;

            if (int.TryParse(cmb_guncelleseviye.SelectedValue.ToString(), out int id))
            {
                seviye_id = id;
            }
        }

        private void cmb_ekleseviye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ekleseviye.SelectedValue == null) return;
            if (cmb_ekleseviye.SelectedValue is DataRowView) return;

            seviye_id = Convert.ToInt32(cmb_ekleseviye.SelectedValue);
        }


        private void btn_tipekle_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
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
            if (cmb_ekletip.SelectedValue == null) return;
            if (cmb_ekletip.SelectedValue is DataRowView) return;

            tip_id = Convert.ToInt32(cmb_ekletip.SelectedValue);
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
    }
}
