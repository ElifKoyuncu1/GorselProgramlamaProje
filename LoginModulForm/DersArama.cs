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
        private DersYonetimi _anaForm;
        public DersArama(DersYonetimi gelenForm)
        {
            InitializeComponent();

            _anaForm = gelenForm; // Gelen formu hafızaya aldık
        }

        public string islemTipi;
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";


        private void btn_ara_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);
            string d_ad=text_araad.Text.Trim();
            string d_blm = cmb_arabolum.Text.Trim();
            string d_tip=cmb_aratip.Text.Trim();
            string d_seviye=cmb_araseviye.Text.Trim();
            string query = @"SELECT d.DersID, d.DersAdi, b.BolumID, b.BolumAd, dt.DersTipiID, dt.TipAd, ss.SinifSeviyeID, ss.SeviyeNo, d.Kredi, d.SinavSuresi, d.DersiAlanOgrenciSayisi
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
                    _anaForm.secilenDersId = Convert.ToInt32(dt.Rows[0]["DersID"]);
                    _anaForm.text_silad.Text = dt.Rows[0]["DersAdi"].ToString();
                    _anaForm.text_silbolum.Text = dt.Rows[0]["BolumAd"].ToString();
                    _anaForm.text_siltip.Text = dt.Rows[0]["TipAd"].ToString();
                    _anaForm.text_silseviye.Text = dt.Rows[0]["SeviyeNo"].ToString();
                    _anaForm.text_silkredi.Text = dt.Rows[0]["Kredi"].ToString();
                    _anaForm.text_silsure.Text = dt.Rows[0]["SinavSuresi"].ToString();
                    _anaForm.text_silmevcud.Text = dt.Rows[0]["DersiAlanOgrenciSayisi"].ToString();
                }

                else if (islemTipi == "guncelle")
                {
                    _anaForm.secilenDersId = Convert.ToInt32(dt.Rows[0]["DersID"]);
                    _anaForm.text_guncellead.Text = dt.Rows[0]["DersAdi"].ToString();

                    // Önce bölümü seçtiriyoruz (Bu işlem otomatik olarak sınıf seviyelerini dolduracak)
                    _anaForm.cmb_guncellebolum.SelectedValue = dt.Rows[0]["BolumID"];
                    _anaForm.cmb_guncelletip.SelectedValue = dt.Rows[0]["DersTipiID"];

                    // Sınıf seviyesinin dolması için değeri bağlıyoruz
                    _anaForm.cmb_guncelleseviye.SelectedValue = dt.Rows[0]["SinifSeviyeID"];

                    _anaForm.nmup_guncellekredi.Value = Convert.ToDecimal(dt.Rows[0]["Kredi"]);
                    _anaForm.nmup_guncellesure.Value = Convert.ToDecimal(dt.Rows[0]["SinavSuresi"]);
                    _anaForm.nmup_guncelleogrsayisi.Value = Convert.ToDecimal(dt.Rows[0]["DersiAlanOgrenciSayisi"]);
                }
                _anaForm.Show();
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
            string queryBolum =
            "SELECT BolumID, BolumAd FROM Bolum";

            DataTable dtBolum =
            db.ExecuteQuery(queryBolum);

            cmb_arabolum.DataSource = dtBolum;

            cmb_arabolum.DisplayMember ="BolumAd";

            cmb_arabolum.ValueMember ="BolumID";

            cmb_arabolum.SelectedIndex = -1;


            // DERS TİPLERİ
            string queryTip =
            "SELECT DersTipiID, TipAd FROM DersTipi";

            DataTable dtTip =
            db.ExecuteQuery(queryTip);

            cmb_aratip.DataSource = dtTip;

            cmb_aratip.DisplayMember ="TipAd";

            cmb_aratip.ValueMember ="DersTipiID";

            cmb_aratip.SelectedIndex = -1;

        }

        private void label25_Click_1(object sender, EventArgs e)
        {
            _anaForm.Show();
            this.Hide();
        }
    }
}
