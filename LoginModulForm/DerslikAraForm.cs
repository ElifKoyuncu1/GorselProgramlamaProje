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
    public partial class DerslikAraForm : Form
    {
        
        public DerslikAraForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";
        public string islemTipi;
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDerslikAdi.Text))
            {
                MessageBox.Show("Aranacak derslik adını giriniz.");
                return;
            }

            DataBaseClass db = new DataBaseClass(connectionString);

            DerslikYonetimi dfrm = new DerslikYonetimi();

            string derslikAd = txtDerslikAdi.Text.Trim();

            string query = @"
            SELECT
                DerslikID,
                DerslikAd,
                Kapasite
            FROM Derslik
            WHERE
                (@ad = '' OR DerslikAd = @ad)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ad", derslikAd)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                if (islemTipi == "sil")
                {
                    dfrm.secilenDerslikID =
                    Convert.ToInt32(dt.Rows[0]["DerslikID"]);

                    dfrm.text_dersSil.Text =
                    dt.Rows[0]["DerslikAd"].ToString();

                    dfrm.num_sil.Value =
                    Convert.ToDecimal(dt.Rows[0]["Kapasite"]);
                }

                else if (islemTipi == "guncelle")
                {
                    dfrm.secilenDerslikID =
                    Convert.ToInt32(dt.Rows[0]["DerslikID"]);

                    dfrm.text_drsGuncelle.Text =
                    dt.Rows[0]["DerslikAd"].ToString();

                    dfrm.num_guncelle.Value =
                    Convert.ToDecimal(dt.Rows[0]["Kapasite"]);
                }

                dfrm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı.");
            }

        }

        private void label_bolumgeri_Click(object sender, EventArgs e)
        {
            DerslikYonetimi dytm = new DerslikYonetimi();
            dytm.Show();
            this.Hide();
        }
    }
}
