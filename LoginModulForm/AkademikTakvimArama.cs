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
    public partial class AkademikTakvimArama : Form
    {
        public AkademikTakvimArama()
        {
            InitializeComponent();
        }

        public string islemTipi;

        string connectionString =@"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";

        private void btn_ara_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            AkademikTakvim akytm = new AkademikTakvim();

            if (cmb_donemara.SelectedIndex == -1 || cmb_snvtipara.SelectedIndex == -1)
            {
                MessageBox.Show("Dönem ve sınav tipi seçiniz.");
                return;
            }

            string donem = cmb_donemara.Text.Trim();
            string sinavTipi = cmb_snvtipara.Text.Trim();

            string query = @"
            SELECT TOP 1
                TakvimID,
                DonemAdi,
                SinavTipi,
                BaslangicTarihi,
                BitisTarihi
            FROM AkademikTakvim
            WHERE DonemAdi = @donem
            AND SinavTipi = @tip";

            SqlParameter[] parameters =
            {
                new SqlParameter("@donem", donem),
                new SqlParameter("@tip", sinavTipi)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                if (islemTipi == "sil")
                {
                    akytm.secilenTakvimID = Convert.ToInt32(dt.Rows[0]["TakvimID"]);
                    akytm.text_dnmsil.Text = dt.Rows[0]["DonemAdi"].ToString();
                    akytm.text_tipsil.Text = dt.Rows[0]["SinavTipi"].ToString();
                    akytm.text_bastrhsil.Text = dt.Rows[0]["BaslangicTarihi"].ToString();
                    akytm.text_bittrhsil.Text = dt.Rows[0]["BitisTarihi"].ToString();

                }

                else if (islemTipi == "guncelle") { 
                    akytm.secilenTakvimID = Convert.ToInt32(dt.Rows[0]["TakvimID"]);
                    akytm.cmb_dnmguncelle.Text = dt.Rows[0]["DonemAdi"].ToString();
                    akytm.cmb_tipguncelle.Text = dt.Rows[0]["SinavTipi"].ToString();
                    akytm.dtp_basguncelle.Value = Convert.ToDateTime(dt.Rows[0]["BaslangicTarihi"]);
                    akytm.dtp_bitguncelle.Value = Convert.ToDateTime(dt.Rows[0]["BitisTarihi"]);
                }
                akytm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
        }

        private void label2_bolum_Click(object sender, EventArgs e)
        {
            AkademikTakvim akytm = new AkademikTakvim();
            akytm.Show();
            this.Hide();
        }
    }
}
