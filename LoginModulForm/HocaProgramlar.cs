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
    public partial class HocaProgramlar : Form

    {
        private int gelenBolumID;
        private string gelenVersiyon;
        public HocaProgramlar(int bolumID, string versiyon)
        {
            InitializeComponent();
            this.gelenBolumID = bolumID;
            this.gelenVersiyon = versiyon;
        }

        string connectionString = @"Data Source=localhost; Initial Catalog=SinavProgrami; Integrated Security=true";
        private void HocaProgramlar_Load(object sender, EventArgs e)
        {

        }
    }
}
