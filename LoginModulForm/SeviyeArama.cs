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
    public partial class SeviyeArama : Form
    {
        public SeviyeArama()
        {
            InitializeComponent();
        }
        public int secilenSeviyeID = 0;
        public string islemTipi;
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";
        private void btn_seviyeara_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            string bolumAd = cmb_seviyebolum.Text.Trim();
            string seviyeNo = cmb_seviyeno.Text.Trim();

            if (string.IsNullOrWhiteSpace(bolumAd) || string.IsNullOrWhiteSpace(seviyeNo))
            {
                MessageBox.Show("Bölüm ve seviye seç");
                return;
            }

            string query = @"                       
            SELECT ss.SinifSeviyeID,
                    ss.SeviyeNo,
                    ss.SinifMevcudu,
                    b.BolumAd
            FROM SinifSeviyesi ss
            INNER JOIN Bolum b
            ON ss.BolumID = b.BolumID
            WHERE b.BolumAd = @bad
              AND ss.SeviyeNo = @sno";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@bad", bolumAd),
                new SqlParameter("@sno", seviyeNo)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                SinifYonetimi sf = new SinifYonetimi();
                sf.secilenSeviyeID = Convert.ToInt32(dt.Rows[0]["SinifSeviyeID"]);

                if (islemTipi == "sil")
                {
                    sf.text_seviyebolumsil.Text = dt.Rows[0]["BolumAd"].ToString();
                    sf.text_seviyenosil.Text = dt.Rows[0]["SeviyeNo"].ToString();
                    sf.text_seviyemevcudsil.Text = dt.Rows[0]["SinifMevcudu"].ToString();
                }

                else if (islemTipi == "guncelle")
                {
                    sf.cmb_bolumguncelle.Text= dt.Rows[0]["BolumAd"].ToString();
                    sf.cmb_seviyeguncelle.Text= dt.Rows[0]["SeviyeNo"].ToString();
                    sf.nmup_mcdguncelle.Value= Convert.ToDecimal(dt.Rows[0]["SinifMevcudu"]);
                }
                sf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı");
            }
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

            cmb_seviyeno.Items.Clear();
            cmb_seviyeno.Items.Add("1");
            cmb_seviyeno.Items.Add("2");
            cmb_seviyeno.Items.Add("3");
            cmb_seviyeno.Items.Add("4");

            cmb_seviyeno.SelectedIndex = -1;

        }

        private void lbl_klytm_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinifYonetimi sfytm=new SinifYonetimi();
            sfytm.Show();
        }
    }
}
