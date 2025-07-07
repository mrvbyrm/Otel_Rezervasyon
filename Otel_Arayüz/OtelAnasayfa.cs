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
    public partial class OtelAnasayfa : Form
    {
        public OtelAnasayfa()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş aa = new AnaSayfaGiriş();
            this.Hide();
            aa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yiciotel yici = new yiciotel();
            this.Hide();
            yici.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ydısıotel ydisi = new ydısıotel();
            this.Hide();
            ydisi.Show();
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

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            GirişSayfaları ag = new GirişSayfaları();
            this.Hide();
            ag.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            GirişSayfaları ag = new GirişSayfaları();
            this.Hide();
            ag.Show();
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }
    }
}
