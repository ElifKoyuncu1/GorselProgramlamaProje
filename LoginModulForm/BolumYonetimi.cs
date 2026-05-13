using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginModulForm
{
    public partial class BolumYonetimi : Form
    {
        public BolumYonetimi()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";
        public int secilenBolumId;

        private void btn_bolumekle_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            
            string b_ad_ek = text_eklebolum.Text.Trim();
            if (string.IsNullOrWhiteSpace(b_ad_ek))
            {
                MessageBox.Show("Lütfen bir bölüm ismi giriniz");
                return;
            }


            string kontrolQuery = "SELECT COUNT(*) FROM Bolum WHERE BolumAd=@ad";

            SqlParameter[] kontrolParameters = new SqlParameter[]
            {
                new SqlParameter("@ad", b_ad_ek)
            };

            DataTable dt = db.ExecuteQuery(kontrolQuery, kontrolParameters);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                MessageBox.Show("Bu bölüm zaten mevcut");
                return;
            }
            string query = "INSERT INTO Bolum(BolumAd) VALUES (@badi)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@badi", b_ad_ek)
            };
            int sonuc = db.ExecuteNonQuery(query, parameters);
            if (sonuc > 0)
            {
                MessageBox.Show("Bölüm Eklendi");
                text_eklebolum.Clear();
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }

        private void btn_bolumsil_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            DialogResult mesaj = MessageBox.Show(" Bu kaydı silmek stediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.Yes)
            {
                string b_ad_sil = text_silbolum.Text.Trim();
                string query = "Delete from Bolum where BolumAd=@ad";
                SqlParameter[] parameter = new SqlParameter[]
                {
                new SqlParameter("@ad", b_ad_sil)

                };
                int d_kyt_sy = db.ExecuteNonQuery(query, parameter);
                if (d_kyt_sy > 0)
                {
                    MessageBox.Show("Bölüm Silindi");
                    text_silbolum.Clear();

                }
                else
                {
                    MessageBox.Show("Bölüm Silinmedi");
                }

            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi");
            }

        }


        private void btn_guncellebolum_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            DialogResult mesaj = MessageBox.Show(" Bu kaydı güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.Yes)
            {
                string b_ad = text_guncellebolum.Text.Trim();
                string query = "UPDATE Bolum SET BolumAd=@b_ad WHERE BolumID=@b_id";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@b_ad", b_ad),
                new SqlParameter("@b_id", secilenBolumId)
                };
                int g_kyt_say = db.ExecuteNonQuery(query, parameters);
                if (g_kyt_say > 0)
                {
                    MessageBox.Show("Bölüm Güncellendi");
                    text_guncellebolum.Clear();
                }
                else
                {
                    MessageBox.Show("Bölüm Güncellenmedi");
                }
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi iptal edildi");
            }
            
        }

        private void btn_bolumlistele_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            string query = "SELECT * FROM Bolum";
            DataTable dt = db.ExecuteQuery(query);
            dataGrid_bolumlistele.DataSource = dt;
            dataGrid_bolumlistele.Columns["BolumID"].Visible = false;
            dataGrid_bolumlistele.Columns["BolumAd"].HeaderText = "Bölüm Adı";
        }

        private void label_bolumgeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
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

        private void text_silbolum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                BolumArama bfrm = new BolumArama();
                bfrm.islemTipi = "sil";
                bfrm.Show();
                this.Hide();
            }

        }

        private void text_guncellebolum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                BolumArama bfrm = new BolumArama();
                bfrm.islemTipi = "guncelle";
                bfrm.Show();
                this.Hide();
            }
        }

        private void BolumYonetimi_Load(object sender, EventArgs e)
        {
            ToolTip mesaj = new ToolTip();
            mesaj.ToolTipTitle = "Arama";
            mesaj.ToolTipIcon = ToolTipIcon.Info;
            mesaj.ShowAlways = true;
            mesaj.SetToolTip(text_silbolum, "Arama için F4 tuşuna basınız");
            mesaj.SetToolTip(text_guncellebolum, "Arama için F4 tuşuna basınız");
        }
    }
}
