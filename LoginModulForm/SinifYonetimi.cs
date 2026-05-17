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
    public partial class SinifYonetimi : Form
    {
        public SinifYonetimi()
        {
            InitializeComponent();
        }
        public int secilenSeviyeID = 0;
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";
        private void btn_bolumekle_Click_1(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            string bolumAd = cmb_blmek.Text.Trim();
            int seviyeNo = Convert.ToInt32(cmb_seviyeek.Text);
            int mevcud = (int)nmup_mevcudek.Value;

            try
            {
                // 1) BolumID + seviye var mı kontrol
                string kontrolQuery = @"
                SELECT COUNT(*) 
                FROM SinifSeviyesi ss
                INNER JOIN Bolum b ON ss.BolumID = b.BolumID
                WHERE b.BolumAd = @b AND ss.SeviyeNo = @s";

                SqlParameter[] kontrolParams =
                {
                    new SqlParameter("@b", bolumAd),
                    new SqlParameter("@s", seviyeNo)
                };

                DataTable kontrolDt = db.ExecuteQuery(kontrolQuery, kontrolParams);

                if (Convert.ToInt32(kontrolDt.Rows[0][0]) > 0)
                {
                    MessageBox.Show("Bu bölüm için bu seviye zaten mevcut!");
                    return;
                }

                // 2) Insert
                string insertQuery = @"
                INSERT INTO SinifSeviyesi (SeviyeNo, SinifMevcudu, BolumID)
                SELECT @sno, @smvcd, b.BolumID 
                FROM Bolum b 
                WHERE b.BolumAd = @bolumAd";

                SqlParameter[] insertParams =
                {
                    new SqlParameter("@sno", seviyeNo),
                    new SqlParameter("@smvcd", mevcud),
                    new SqlParameter("@bolumAd", bolumAd)
                };

                int sonuc = db.ExecuteNonQuery(insertQuery, insertParams);

                if (sonuc > 0)
                    MessageBox.Show("Sınıf seviyesi eklendi");
                else
                    MessageBox.Show("Bölüm bulunamadı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void SinifYonetimi_Load(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            string query = "SELECT BolumAd FROM Bolum";
            DataTable dt = db.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_blmek.Items.Add(dt.Rows[i][0].ToString());
                cmb_bolumguncelle.Items.Add(dt.Rows[i][0].ToString());

            }

            cmb_blmek.SelectedIndex = -1;
            cmb_bolumguncelle.SelectedIndex = -1;


            ToolTip mesaj = new ToolTip();
            mesaj.ToolTipTitle = "Arama";
            mesaj.ToolTipIcon = ToolTipIcon.Info;
            mesaj.ShowAlways = true;
            mesaj.SetToolTip(text_seviyebolumsil, "Arama için F4 tuşuna basınız");

        }

        private void label_seviyegeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
        }

        private void btn_seviyelistele_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseClass db = new DataBaseClass(connectionString);
                string query = @"SELECT ss.SinifSeviyeID, ss.SeviyeNo, ss.SinifMevcudu, b.BolumAd FROM SinifSeviyesi ss LEFT JOIN Bolum b ON ss.BolumID = b.BolumID";
                DataTable dt = db.ExecuteQuery(query);
                dataGrid_seviyelistele.AutoGenerateColumns = true;
                dataGrid_seviyelistele.DataSource = dt;
                dataGrid_seviyelistele.Columns["SinifSeviyeID"].Visible = false;
                dataGrid_seviyelistele.Columns["SeviyeNo"].HeaderText = "Sınıf Seviyesi";
                dataGrid_seviyelistele.Columns["BolumAd"].HeaderText = "Bölüm Adı";
                dataGrid_seviyelistele.Columns["SinifMevcudu"].HeaderText = "Sınıf Mevcudu";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_seviyesil_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            DialogResult mesaj = MessageBox.Show(
                "Bu kaydı silmek istediğinize emin misiniz?",
                "Uyarı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (mesaj == DialogResult.Yes)
            {
                string bolumAd = text_seviyebolumsil.Text.Trim();
                int seviyeNo = Convert.ToInt32(text_seviyenosil.Text);
                int sinifMevcudu = Convert.ToInt32(text_seviyemevcudsil.Text);

                // Önce ilgili SinifSeviyeID bulunuyor
                string idQuery = @"
                SELECT ss.SinifSeviyeID
                FROM SinifSeviyesi ss
                INNER JOIN Bolum b
                 ON ss.BolumID = b.BolumID
                 WHERE b.BolumAd = @bad
                 AND ss.SeviyeNo = @sno
                 AND ss.SinifMevcudu = @sm";

                SqlParameter[] idParameters = new SqlParameter[]
                {
                     new SqlParameter("@bad", bolumAd),
                     new SqlParameter("@sno", seviyeNo),
                     new SqlParameter("@sm", sinifMevcudu)
                };

                DataTable dt = db.ExecuteQuery(idQuery, idParameters);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Kayıt bulunamadı");
                    return;
                }

                int sinifSeviyeID =
                    Convert.ToInt32(dt.Rows[0]["SinifSeviyeID"]);

                // Bu seviyeye bağlı ders var mı kontrol ediliyor
                string kontrolQuery =
                    "SELECT * FROM Ders WHERE SinifSeviyeID=@id";

                SqlParameter[] kontrolParameters = new SqlParameter[]
                {
                     new SqlParameter("@id", sinifSeviyeID)
                };

                DataTable kontrolDt =
                    db.ExecuteQuery(kontrolQuery, kontrolParameters);

                if (kontrolDt.Rows.Count > 0)
                {
                    MessageBox.Show("Bu seviyeye ait ders bulunduğu için silinemez");
                    return;
                }

                // Silme işlemi
                string deleteQuery =
                    "DELETE FROM SinifSeviyesi WHERE SinifSeviyeID=@id";

                SqlParameter[] deleteParameters = new SqlParameter[]
                {
                    new SqlParameter("@id", sinifSeviyeID)
                };

                int sonuc =
                    db.ExecuteNonQuery(deleteQuery, deleteParameters);

                if (sonuc > 0)
                {
                    MessageBox.Show("Seviye silindi");
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

        private void label2_bolum_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
        }

        private void label6_bolum_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
        }

        private void label_geri4_bolum_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
        }

        private void btn_seviyeguncelle_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = MessageBox.Show("Bu kaydı güncellemek istediğinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (mesaj != DialogResult.Yes)
                return;

            DataBaseClass db = new DataBaseClass(connectionString);

            string bolumAd = cmb_bolumguncelle.Text.Trim();
            int yeniSeviye = Convert.ToInt32(cmb_seviyeguncelle.Text);
            int yeniMevcut = (int)nmup_mcdguncelle.Value;

            try
            {
                // 1) ÇAKIŞMA KONTROLÜ
                string kontrolQuery = @"
                SELECT COUNT(*) 
                FROM SinifSeviyesi ss
                INNER JOIN Bolum b ON ss.BolumID = b.BolumID
                WHERE b.BolumAd = @b 
                AND ss.SeviyeNo = @s 
                AND SS.SinifMevcudu=@m
                AND ss.SinifSeviyeID != @id";

                SqlParameter[] kontrolParams =
                {
                    new SqlParameter("@b", bolumAd),
                    new SqlParameter("@s", yeniSeviye),
                    new SqlParameter("@id", secilenSeviyeID),
                    new SqlParameter("@m", yeniMevcut)
                };

                DataTable kontrolDt = db.ExecuteQuery(kontrolQuery, kontrolParams);

                if (Convert.ToInt32(kontrolDt.Rows[0][0]) > 0)
                {
                    MessageBox.Show("Bu bölümde bu seviye zaten var!");
                    return;
                }

                // 2) UPDATE
                string query = @"
                UPDATE SinifSeviyesi
                SET SeviyeNo = @s,
                SinifMevcudu = @m
                WHERE SinifSeviyeID = @id";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@s", yeniSeviye),
                    new SqlParameter("@m", yeniMevcut),
                    new SqlParameter("@id", secilenSeviyeID)
        };

                int sonuc = db.ExecuteNonQuery(query, parameters);

                if (sonuc > 0)
                    MessageBox.Show("Güncellendi");
                else
                    MessageBox.Show("Kayıt bulunamadı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void text_seviyebolumsil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                SeviyeArama sfrm = new SeviyeArama();
                sfrm.islemTipi = "sil";
                sfrm.Show();
                this.Hide();
            }
        }

        private void cmb_bolumguncelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                SeviyeArama sfrm = new SeviyeArama();
                sfrm.islemTipi = "guncelle";
                sfrm.Show();
                this.Hide();
            }
        }
    }
}
