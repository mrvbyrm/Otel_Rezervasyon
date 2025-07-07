using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tatil_Rezervasyon_Otomasyonu
{
    public partial class GirişSayfaları : Form
    {
        public GirişSayfaları()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GirişSayfaları_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            girisyap grs = new girisyap();
            this.Hide();
            grs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admingiris ad = new admingiris();
            this.Hide();
            ad.Show();
        }

        private void otellerButton_Click(object sender, EventArgs e)
        {
            OtelAnasayfa oa = new OtelAnasayfa();
            this.Hide();
            oa.Show();
        }

        private void turlarButton_Click(object sender, EventArgs e)
        {
            TurAnaSayfa ta = new TurAnaSayfa();
            this.Hide();
            ta.Show();
        }

        private void kampanyalarButton_Click(object sender, EventArgs e)
        {
            kampanya ka = new kampanya();
            this.Hide();
            ka.Show();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
