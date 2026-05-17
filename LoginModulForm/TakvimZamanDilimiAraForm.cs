using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginModulForm
{
    public partial class TakvimZamanDilimiAraForm : Form
    {

        public TakvimZamanDilimiAraForm()
        {
            InitializeComponent();

        }

        public string islemTipi;
        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami;Integrated Security=true";
        private void btnAra_Click(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            TakvimZamanDilimi tzm = new TakvimZamanDilimi();

            int takvimID = 0;

            // combobox seçildiyse ID al
            if (cmbAraDonemTipi.SelectedIndex != -1)
            {
                takvimID = Convert.ToInt32(cmbAraDonemTipi.SelectedValue);
            }

            DateTime tarih = dtpAraTarih.Value.Date;

            string query = @"
    SELECT 
        z.ZamanID,
        z.TakvimID,
        a.DonemAdi,
        a.SinavTipi,
        z.Tarih,
        z.BaslangicSaat,
        z.BitisSaat
    FROM ZamanDilimi z
    INNER JOIN AkademikTakvim a
    ON z.TakvimID = a.TakvimID
    WHERE
    (@tid = 0 OR z.TakvimID = @tid)
    AND z.Tarih = @tarih";

            SqlParameter[] parameters =
            {
        new SqlParameter("@tid", takvimID),
        new SqlParameter("@tarih", tarih)
    };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                if (islemTipi == "sil")
                {
                    tzm.secilenZamanID =
                    Convert.ToInt32(dt.Rows[0]["ZamanID"]);

                    tzm.text_dnmsil.Text =
                    dt.Rows[0]["DonemAdi"].ToString()
                    + " - " +
                    dt.Rows[0]["SinavTipi"].ToString();

                    tzm.text_trhsil.Text =
                    Convert.ToDateTime(dt.Rows[0]["Tarih"])
                    .ToShortDateString();

                    tzm.text_bassil.Text =
                    dt.Rows[0]["BaslangicSaat"].ToString();

                    tzm.text_bitsil.Text =
                    dt.Rows[0]["BitisSaat"].ToString();
                }

                else if (islemTipi == "guncelle")
                {
                    tzm.secilenZamanID =
                    Convert.ToInt32(dt.Rows[0]["ZamanID"]);

                    tzm.cmb_guncelle.SelectedValue =
                    dt.Rows[0]["TakvimID"];

                    tzm.dtp_guncelle.Value =
                    Convert.ToDateTime(dt.Rows[0]["Tarih"]);

                    tzm.dtp_basguncelle.Value =
                    DateTime.Today.Add(
                    (TimeSpan)dt.Rows[0]["BaslangicSaat"]);

                    tzm.dtp_bitguncelle.Value =
                    DateTime.Today.Add(
                    (TimeSpan)dt.Rows[0]["BitisSaat"]);
                }

                tzm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı.");
            }

        }

        private void TakvimZamanDilimiAraForm_Load(object sender, EventArgs e)
        {
            DataBaseClass db = new DataBaseClass(connectionString);

            string query = @"
            SELECT 
                TakvimID,
                DonemAdi + ' - ' + SinavTipi AS DonemTipi
            FROM AkademikTakvim";

            DataTable dt = db.ExecuteQuery(query);

            cmbAraDonemTipi.DataSource = dt;

            cmbAraDonemTipi.DisplayMember = "DonemTipi";

            cmbAraDonemTipi.ValueMember = "TakvimID";

            cmbAraDonemTipi.SelectedIndex = -1;
        }
    }
}
