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
    public partial class rino : Form
    {
        public rino()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            ydısıotel ydisi = new ydısıotel();
            this.Hide();
            ydisi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            renostandartoda ro = new renostandartoda();
            this.Hide();
            ro.Show();
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

        private void label22_Click_1(object sender, EventArgs e)
        {
            ydısıotel yd = new ydısıotel();
            this.Hide();
            yd.Show();

        }

        private void label14_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş aa = new AnaSayfaGiriş();
            this.Hide();
            aa.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş aa = new AnaSayfaGiriş();
            this.Hide();
            aa.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }
    }
}
