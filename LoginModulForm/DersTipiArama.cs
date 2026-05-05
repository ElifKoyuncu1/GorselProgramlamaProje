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
    public partial class DersTipiArama : Form
    {
        public DersTipiArama()
        {
            InitializeComponent();
        }

        public string islemTipi;
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";
        private void btn_aratip_Click(object sender, EventArgs e)
        {
            DersYonetimi dytm = new DersYonetimi();
            DataBaseClass db = new DataBaseClass(connectionString);
            string d_tip = cmb_tipara.Text;
            string query = @"SELECT DersTipiID, TipAd FROM DersTipi WHERE TipAd=@t_ad ";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@t_ad", d_tip)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                dytm.secilenTipId = Convert.ToInt32(dt.Rows[0]["DersTipiID"]);
                dytm.Show();
                this.Hide();

                if (islemTipi == "sil")
                {
                    dytm.text_tipsil.Text = dt.Rows[0]["TipAd"].ToString();

                }
                else if (islemTipi == "guncelle")
                {
                    dytm.text_tipguncelle.Text = dt.Rows[0]["TipAd"].ToString();

                }
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı");
            }

        }

        private void DersTipiArama_Load(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            string query = "SELECT TipAd FROM DersTipi";
            DataTable dt = db.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_tipara.Items.Add(dt.Rows[i][0].ToString());
            }

            cmb_tipara.SelectedIndex = -1;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DersYonetimi dytm = new DersYonetimi();
            dytm.Show();
        }
    }
}
