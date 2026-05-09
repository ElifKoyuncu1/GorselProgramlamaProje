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
    public partial class BolumArama : Form
    {
        public BolumArama()
        {
            InitializeComponent();
        }
        public string islemTipi;
        public int secilenBolumId;
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";

        private void btn_arabolum_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            int b_id = (int)cmb_bolum.SelectedValue;

            string query = @"SELECT BolumID, BolumAd FROM Bolum WHERE BolumID=@id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", b_id)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                BolumYonetimi bytm = new BolumYonetimi();

                bytm.secilenBolumId = Convert.ToInt32(dt.Rows[0]["BolumID"]);

                string bolumAd = dt.Rows[0]["BolumAd"].ToString();

                if (islemTipi == "sil")
                {
                    bytm.text_silbolum.Text = bolumAd;
                }
                else if (islemTipi == "guncelle")
                {
                    bytm.text_guncellebolum.Text = bolumAd;
                }

                bytm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı");
            }

        }

        private void BolumArama_Load(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            string query = "SELECT BolumID, BolumAd FROM Bolum";
            DataTable dt = db.ExecuteQuery(query);

            cmb_bolum.DataSource = dt;
            cmb_bolum.DisplayMember = "BolumAd";
            cmb_bolum.ValueMember = "BolumID";
            cmb_bolum.SelectedIndex = -1;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            BolumYonetimi blytm = new BolumYonetimi();
            blytm.Show();
        }
    }
}
