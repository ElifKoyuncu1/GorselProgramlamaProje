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
    public partial class DerslikYonetimi : Form
    {
        public DerslikYonetimi()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";

        public int secilenDerslikID = 0;

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            string derslikAd = text_drsEkle.Text.Trim();

            int kapasite = (int)num_ekle.Value;

            if (derslikAd == "")
            {
                MessageBox.Show("Derslik adı boş bırakılamaz.");
                return;
            }

            string kontrolQuery =
            "SELECT * FROM Derslik WHERE DerslikAd=@ad";

            SqlParameter[] kontrolParameters =
            {
                new SqlParameter("@ad", derslikAd)
            };

            DataTable kontrol = db.ExecuteQuery(kontrolQuery, kontrolParameters);

            if (kontrol.Rows.Count > 0)
            {
                MessageBox.Show("Bu derslik zaten kayıtlı.");
                return;
            }

            string query = @"
            INSERT INTO Derslik
            (DerslikAd, Kapasite)
            VALUES
            (@ad, @kapasite)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ad", derslikAd),
                new SqlParameter("@kapasite", kapasite)
            };

            int sonuc = db.ExecuteNonQuery(query, parameters);

            if (sonuc > 0)
            {
                MessageBox.Show("Derslik başarıyla eklendi.");

                text_drsEkle.Clear();

                num_ekle.Value = 1;
            }
            else
            {
                MessageBox.Show("Ekleme işlemi başarısız.");
            }
        }


        private void btn_sil_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_dersSil.Text))
            {
                MessageBox.Show("Silmek için derslik adını giriniz.");
                return;
            }

            DataBaseClass db = new DataBaseClass(connectionString);

            DialogResult mesaj = MessageBox.Show(
                "Bu dersliği silmek istediğinize emin misiniz?",
                "Uyarı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (mesaj == DialogResult.Yes)
            {
                string derslikAd = text_dersSil.Text.Trim();

                string query =
                "DELETE FROM Derslik WHERE DerslikAd=@ad";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ad", derslikAd)
                };

                int sonuc = db.ExecuteNonQuery(query, parameters);

                if (sonuc > 0)
                {
                    MessageBox.Show("Derslik silindi.");

                    text_dersSil.Clear();

                    num_sil.Value = 1;
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız.");
                }
            }
        }

        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            DialogResult mesaj = MessageBox.Show(
                "Bu dersliği güncellemek istediğinize emin misiniz?",
                "Uyarı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (mesaj == DialogResult.Yes)
            {
                string derslikAd = text_drsGuncelle.Text.Trim();

                int kapasite = (int)num_guncelle.Value;

                string query = @"
                UPDATE Derslik
                SET
                    DerslikAd=@ad,
                    Kapasite=@kapasite
                WHERE DerslikID=@id";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@ad", derslikAd),
                    new SqlParameter("@kapasite", kapasite),
                    new SqlParameter("@id", secilenDerslikID)
                };

                int sonuc = db.ExecuteNonQuery(query, parameters);

                if (sonuc > 0)
                {
                    MessageBox.Show("Derslik güncellendi.");

                    text_drsGuncelle.Clear();

                    num_guncelle.Value = 1;


                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız.");
                }
            }
        }
  

        private void btn_listele_Click_1(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            string query = @"
            SELECT
              DerslikID,
              DerslikAd,
              Kapasite
            FROM Derslik";

            DataTable dt = db.ExecuteQuery(query);

            dataGridView1.DataSource = dt;


            dataGridView1.Columns["DerslikAd"].HeaderText = "Derslik Adı";

            dataGridView1.Columns["Kapasite"].HeaderText = "Kapasite";

        }
     

        private void lbl_dekle_Click_1(object sender, EventArgs e)
        {
            YoneticiModul frm = new YoneticiModul();
            frm.Show();
            this.Hide();
        }

        private void lbl_dsil_Click(object sender, EventArgs e)
        {
            YoneticiModul frm = new YoneticiModul();
            frm.Show();
            this.Hide();
        }

        private void lbl_dgncl_Click(object sender, EventArgs e)
        {
            YoneticiModul frm = new YoneticiModul();
            frm.Show();
            this.Hide();
        }

        private void lbl_dlstl_Click(object sender, EventArgs e)
        {
            YoneticiModul frm = new YoneticiModul();
            frm.Show();
            this.Hide();
        }

        private void DerslikYonetimi_Load(object sender, EventArgs e)
        {
            ToolTip mesaj = new ToolTip();

            mesaj.ToolTipTitle = "Arama";
            mesaj.ToolTipIcon = ToolTipIcon.Info;
            mesaj.ShowAlways = true;

            mesaj.SetToolTip(text_drsGuncelle, "Arama için F4 tuşuna basınız");
            mesaj.SetToolTip(text_dersSil, "Arama için F4 tuşuna basınız");
        }

        private void text_dersSil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                DerslikAraForm frm = new DerslikAraForm();

                frm.islemTipi = "sil";

                frm.Show();

                this.Hide();
            }
        }

        private void text_drsGuncelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                DerslikAraForm frm = new DerslikAraForm();

                frm.islemTipi = "guncelle";

                frm.Show();

                this.Hide();
            }
        }
    }
}
