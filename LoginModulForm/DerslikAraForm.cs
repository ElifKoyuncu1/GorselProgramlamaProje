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
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";

        public int SecilenDerslikID { get; private set; }
        public string SecilenDerslikAd { get; private set; }
        public int SecilenKapasite { get; private set; }

        public DerslikAraForm()
        {
            InitializeComponent();

            num_kapasite.Minimum = 0;
            num_kapasite.Maximum = 1000;
            num_kapasite.Value = 0;
            num_kapasite.ReadOnly = true;

            this.Text = "Derslik Ara";
            groupBox1.Text = "Derslik Ara";
        }

    

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDerslikAdi.Text))
            {
                MessageBox.Show("Aranacak derslik adını giriniz.");
                return;
            }

            string arananDerslikAd = txtDerslikAdi.Text.Trim();

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();

                    string sorgu = @"
                    SELECT TOP 1
                        DerslikID,
                        DerslikAd,
                        Kapasite
                    FROM Derslik
                    WHERE DerslikAd = @derslikAd";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@derslikAd", arananDerslikAd);

                        using (SqlDataReader dr = komut.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                SecilenDerslikID = Convert.ToInt32(dr["DerslikID"]);
                                SecilenDerslikAd = dr["DerslikAd"].ToString();
                                SecilenKapasite = Convert.ToInt32(dr["Kapasite"]);

                                txtDerslikAdi.Text = SecilenDerslikAd;

                                if (SecilenKapasite < num_kapasite.Minimum)
                                    num_kapasite.Value = num_kapasite.Minimum;
                                else if (SecilenKapasite > num_kapasite.Maximum)
                                    num_kapasite.Value = num_kapasite.Maximum;
                                else
                                    num_kapasite.Value = SecilenKapasite;

                                MessageBox.Show("Derslik bulundu. Ana forma aktarılıyor.");

                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                SecilenDerslikID = 0;
                                SecilenDerslikAd = "";
                                SecilenKapasite = 0;

                                num_kapasite.Value = 0;

                                MessageBox.Show("Girilen ada uygun derslik bulunamadı.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama sırasında hata oluştu: " + ex.Message);
            }

        }
    }
}
