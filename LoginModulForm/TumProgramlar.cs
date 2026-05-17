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
    public partial class TumProgramlar : Form
    {
        public TumProgramlar()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";
        private void btn_dosya_indir_Click(object sender, EventArgs e)
        {

        }

        private void TumProgramlar_Load(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            string query = "SELECT BolumAd FROM Bolum";
            DataTable dt = db.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_blmler.Items.Add(dt.Rows[i][0].ToString());
            }

            cmb_blmler.SelectedIndex = -1;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            YoneticiModul yntc = new YoneticiModul();
            yntc.Show();    
            this.Hide();
        }
    }
}
