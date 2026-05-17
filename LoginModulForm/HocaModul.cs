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
    public partial class HocaModul : Form
    {
        int gelenBolumID;
        public HocaModul(int bolumID)
        {
            InitializeComponent();
            gelenBolumID = bolumID;
        }

        private void btn_derslerim_Click(object sender, EventArgs e)
        {
            HocaDersler hd =new HocaDersler(gelenBolumID);
            hd.Show();
        }

        private void btn_programım_Click(object sender, EventArgs e)
        {
            HocaProgramim hp = new HocaProgramim(gelenBolumID);
            hp.Show();
            this.Hide();
        }

        private void btn_programolustur_Click(object sender, EventArgs e)
        {
            SinavProgramiOlustur frm = new SinavProgramiOlustur(gelenBolumID);
            frm.Show();
        }

        private void label2_bolum_Click(object sender, EventArgs e)
        {
            YoneticiModul ym = new YoneticiModul();
            ym.Show();
            this.Hide();
        }
    }
}
