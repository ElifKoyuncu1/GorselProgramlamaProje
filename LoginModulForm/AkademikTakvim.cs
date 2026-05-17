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
    public partial class AkademikTakvim : Form
    {
        public AkademikTakvim()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";

        public int secilenTakvimID = 0;
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (cmb_donemekle.SelectedIndex == -1 || cmb_snvtipekle.SelectedIndex == -1)
            {
                MessageBox.Show("Dönem ve sınav tipi seç.");
                return;
            }

            string donem = cmb_donemekle.Text;
            string sinavTipi = cmb_snvtipekle.Text;

            DateTime bas = dtp_bastrhekle.Value.Date;
            DateTime bit = dth_bittrekle.Value.Date;

            if (bas > bit)
            {
                MessageBox.Show("Başlangıç bitişten büyük olamaz.");
                return;
            }

            DataBaseClass db = new DataBaseClass(connectionString);

            string kontrolQuery = @"
            SELECT * FROM AkademikTakvim
            WHERE DonemAdi=@d AND SinavTipi=@s AND BaslangicTarihi=@b AND BitisTarihi=@bt";

            SqlParameter[] kontrolParams =
            {
                new SqlParameter("@d", donem),
                new SqlParameter("@s", sinavTipi),
                new SqlParameter("@b", bas),
                new SqlParameter("@bt", bit)
            };

            DataTable kontrol = db.ExecuteQuery(kontrolQuery, kontrolParams);

            if (kontrol.Rows.Count > 0)
            {
                MessageBox.Show("Bu kayıt zaten var.");
                return;
            }

            string query = @"
            INSERT INTO AkademikTakvim (DonemAdi, SinavTipi, BaslangicTarihi, BitisTarihi)
            VALUES (@d, @s, @b, @bt)";

            SqlParameter[] prms =
            {
                new SqlParameter("@d", donem),
                new SqlParameter("@s", sinavTipi),
                new SqlParameter("@b", bas),
                new SqlParameter("@bt", bit)
            };

            int sonuc = db.ExecuteNonQuery(query, prms);

            MessageBox.Show(sonuc > 0 ? "Eklendi" : "Hata");

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            DataBaseClass db=new DataBaseClass(connectionString);
            string query = "SELECT * FROM AkademikTakvim";
            DataTable dt = db.ExecuteQuery(query);
            dataGridView1.DataSource = dt;

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            DialogResult mesaj = MessageBox.Show(
                "Bu kaydı silmek istediğinize emin misiniz?",
                "Uyarı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (mesaj == DialogResult.Yes)
            {
                string query = @"DELETE FROM AkademikTakvim WHERE TakvimID = @id";

                SqlParameter[] parameters =
                {
                new SqlParameter("@id", secilenTakvimID)
                };

                int sonuc = db.ExecuteNonQuery(query, parameters);

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt silindi.");

                    text_dnmsil.Clear();
                    text_tipsil.Clear();
                    text_bastrhsil.Clear();
                    text_bittrhsil.Clear();
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

        private void text_dnmsil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                AkademikTakvimArama afrm = new AkademikTakvimArama();
                afrm.islemTipi = "sil";
                afrm.Show();
                this.Hide();
            }
        }

        private void AkademikTakvim_Load(object sender, EventArgs e)
        {
            ToolTip mesaj = new ToolTip();
            mesaj.ToolTipTitle = "Arama";
            mesaj.ToolTipIcon = ToolTipIcon.Info;
            mesaj.ShowAlways = true;
            mesaj.SetToolTip(text_dnmsil, "Arama için F4 tuşuna basınız");
            mesaj.SetToolTip(cmb_dnmguncelle, "Arama için F4 tuşuna basınız");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            DialogResult mesaj = MessageBox.Show("Bu kaydı güncellemek istediğinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (mesaj== DialogResult.Yes)
            {
                string query = @"
                UPDATE AkademikTakvim
                SET 
                  DonemAdi = @donem,
                  SinavTipi = @tip,
                  BaslangicTarihi = @bas,
                  BitisTarihi = @bit
                WHERE TakvimID = @id";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@donem", cmb_dnmguncelle.Text.Trim()),
                    new SqlParameter("@tip", cmb_tipguncelle.Text.Trim()),
                    new SqlParameter("@bas", dtp_basguncelle.Value.Date),
                    new SqlParameter("@bit", dtp_bitguncelle.Value.Date),
                    new SqlParameter("@id", secilenTakvimID)
                };

                int sonuc = db.ExecuteNonQuery(query, parameters);

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

        private void cmb_dnmguncelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                AkademikTakvimArama afrm = new AkademikTakvimArama();
                afrm.islemTipi = "guncelle";
                afrm.Show();
                this.Hide();
            }
        }

        private void label2_bolum_Click(object sender, EventArgs e)
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

        private void label14_Click(object sender, EventArgs e)
        {
            YoneticiModul ymdl = new YoneticiModul();
            ymdl.Show();
            this.Hide();
        }
    }
}
