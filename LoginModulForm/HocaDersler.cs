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
    public partial class HocaDersler : Form
    {
        int gelenBolumID;

        public HocaDersler(int bolumID)
        {
            InitializeComponent();
            gelenBolumID = bolumID;
        }

        private void HocaDersler_Load(object sender, EventArgs e)
        {
            string connectionString =
    @"Data Source=localhost;
      Initial Catalog=SinavProgrami;
      Integrated Security=true";

            SqlConnection conn =
                new SqlConnection(connectionString);

            string query =
            "SELECT * FROM Ders WHERE BolumID=@id";

            SqlCommand cmd =
                new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue(
                "@id",
                gelenBolumID
            );

            SqlDataAdapter da =
                new SqlDataAdapter(cmd);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
