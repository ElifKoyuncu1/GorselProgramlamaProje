using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginModulForm
{
    public partial class DersArama : Form
    {
        public DersArama()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";
        private void label25_Click(object sender, EventArgs e)
        {
            this.Hide();
            DersYonetimi dytm = new DersYonetimi();
            dytm.Show();

        }


        private void btn_ara_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            DersYonetimi dytm = new DersYonetimi();
            string d_ad=text_araad.Text.Trim();


        }

        private void DersArama_Load(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            string query = "SELECT BolumAd FROM Bolum";
            DataTable dt = db.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_arabolum.Items.Add(dt.Rows[i][0].ToString());
            }

        }
    }
}
