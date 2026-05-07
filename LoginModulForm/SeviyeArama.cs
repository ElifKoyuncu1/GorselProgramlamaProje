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
    public partial class SeviyeArama : Form
    {
        public SeviyeArama()
        {
            InitializeComponent();
        }
        public string islemTipi;
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";
        private void btn_seviyeara_Click(object sender, EventArgs e)
        {
            SinifYonetimi sfyn = new SinifYonetimi();
            DataBaseClass db = new DataBaseClass(connectionString);

        }

        private void SeviyeArama_Load(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            string query = "SELECT BolumAd FROM Bolum";
            DataTable dt = db.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_seviyebolum.Items.Add(dt.Rows[i][0].ToString());
            }

            cmb_seviyebolum.SelectedIndex = -1;

        }
    }
}
