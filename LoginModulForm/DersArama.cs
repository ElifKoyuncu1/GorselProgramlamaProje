using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LoginModulForm
{
    public partial class DersArama : Form
    {
        public DersArama()
        {
            InitializeComponent();
        }

        public string islemTipi;
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";


        private void btn_ara_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            DersYonetimi dytm = new DersYonetimi();
            string d_ad=text_araad.Text.Trim();
            string d_blm = cmb_arabolum.Text.Trim();
            string d_tip=cmb_aratip.Text.Trim();
            string d_seviye=cmb_araseviye.Text.Trim();
            string query = @"SELECT d.DersID, d.DersAdi, b.BolumAd, dt.TipAd, ss.SeviyeNo, d.Kredi, d.SinavSuresi, d.DersiAlanOgrenciSayisi
                          FROM Ders d 
                          INNER JOIN Bolum b ON d.BolumID = b.BolumID
                          INNER JOIN DersTipi dt ON d.DersTipiID = dt.DersTipiID
                          INNER JOIN SinifSeviyesi ss ON d.SinifSeviyeID = ss.SinifSeviyeID
                          WHERE 
                          (@dad = '' OR d.DersAdi = @dad)
                          AND (@bad = '' OR b.BolumAd = @bad)
                          AND (@tad = '' OR dt.TipAd = @tad)
                          AND (@sno = '' OR ss.SeviyeNo = @sno)           ";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@dad", d_ad),
                new SqlParameter("@bad", d_blm),
                new SqlParameter("@tad", d_tip),
                new SqlParameter("@sno", d_seviye)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                if (islemTipi == "sil")
                {
                    dytm.secilenDersId = Convert.ToInt32(dt.Rows[0]["DersID"]);
                    dytm.text_silad.Text = dt.Rows[0]["DersAdi"].ToString();
                    dytm.text_silbolum.Text = dt.Rows[0]["BolumAd"].ToString();
                    dytm.text_siltip.Text = dt.Rows[0]["TipAd"].ToString();
                    dytm.text_silseviye.Text = dt.Rows[0]["SeviyeNo"].ToString();
                    dytm.text_silkredi.Text = dt.Rows[0]["Kredi"].ToString();
                    dytm.text_silsure.Text = dt.Rows[0]["SinavSuresi"].ToString();
                    dytm.text_silmevcud.Text = dt.Rows[0]["DersiAlanOgrenciSayisi"].ToString();
                }

                else if (islemTipi == "guncelle")
                {
                    dytm.secilenDersId = Convert.ToInt32(dt.Rows[0]["DersID"]);
                    dytm.text_guncellead.Text = dt.Rows[0]["DersAdi"].ToString();
                    dytm.cmb_guncellebolum.Text = dt.Rows[0]["BolumAd"].ToString();
                    dytm.cmb_guncelletip.Text = dt.Rows[0]["TipAd"].ToString();
                    dytm.cmb_guncelleseviye.Text = dt.Rows[0]["SeviyeNo"].ToString();
                    dytm.nmup_guncellekredi.Value = Convert.ToDecimal(dt.Rows[0]["Kredi"]);
                    dytm.nmup_guncellesure.Value =Convert.ToDecimal(dt.Rows[0]["SinavSuresi"]);
                    dytm.nmup_guncelleogrsayisi.Value =Convert.ToDecimal(dt.Rows[0]["DersiAlanOgrenciSayisi"]);
                }
                dytm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }


        }

        private void DersArama_Load(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            string query = "SELECT BolumAd FROM Bolum";
            string query1 = "SELECT TipAd FROM DersTipi";
            DataTable dt = db.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_arabolum.Items.Add(dt.Rows[i][0].ToString());
            }

            DataTable dtTip = db.ExecuteQuery(query1);
            for (int i = 0; i < dtTip.Rows.Count; i++)
            {
                cmb_aratip.Items.Add(dtTip.Rows[i][0].ToString());
            }

        }

        private void label25_Click_1(object sender, EventArgs e)
        {
            DersYonetimi dytm = new DersYonetimi();
            dytm.Show();
            this.Hide();
        }
    }
}
