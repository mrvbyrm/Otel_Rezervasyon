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
    public partial class TurAnaSayfa : Form
    {
        public TurAnaSayfa()
        {
            InitializeComponent();
        }

        private void turlarButton_Click(object sender, EventArgs e)
        {
            TurAnaSayfa ta = new TurAnaSayfa();
            this.Hide();
            ta.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş tursayfa = new AnaSayfaGiriş();
            this.Hide();
            tursayfa.Show();
        }

        private void karadenizTurlari_Click(object sender, EventArgs e)
        {
            YurtDışıTurları ydisitur = new YurtDışıTurları();
            this.Hide();
            ydisitur.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TurGemiAnasayfa tgm = new TurGemiAnasayfa();
            this.Hide();
            tgm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurlarKültür tk = new TurlarKültür();
            this.Hide();
            tk.Show();
        }

        private void otellerButton_Click(object sender, EventArgs e)
        {
            OtelAnasayfa oa = new OtelAnasayfa();
            this.Hide();
            oa.Show();
        }

        private void kampanyalarButton_Click(object sender, EventArgs e)
        {
            kampanya ka = new kampanya();
            this.Hide();
            ka.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş an = new AnaSayfaGiriş();
            this.Hide();
            an.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş an = new AnaSayfaGiriş();
            this.Hide();
            an.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }
    }
}
