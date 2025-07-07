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
    public partial class thmrmra : Form
    {
        public thmrmra()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            ydısıotel yd = new ydısıotel();
            this.Hide();
            yd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marmarasuitoda ms = new marmarasuitoda();
            this.Hide();
            ms.Show();
        }

        private void kampanyalarButton_Click(object sender, EventArgs e)
        {
            kampanya ka = new kampanya();
            this.Hide();
            ka.Show();
        }

        private void turlarButton_Click(object sender, EventArgs e)
        {
            TurAnaSayfa ta = new TurAnaSayfa();
            this.Hide();
            ta.Show();
        }

        private void otellerButton_Click(object sender, EventArgs e)
        {
            OtelAnasayfa oa = new OtelAnasayfa();
            this.Hide();
            oa.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş hg = new AnaSayfaGiriş();
            this.Hide();
            hg.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş hg = new AnaSayfaGiriş();
            this.Hide();
            hg.Show();
        }

        private void label22_Click_1(object sender, EventArgs e)
        {
            yiciotel yi = new yiciotel();
            this.Hide();
            yi.Show();
        }
    }
}
