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
    public partial class AnaSayfaTur : Form
    {
        public AnaSayfaTur()
        {
            InitializeComponent();
        }

        private void kulturTurlari_Click(object sender, EventArgs e)
        {
            TurlarKültür f3 = new TurlarKültür();
            this.Hide();
            f3.Show();
        }

        private void gemiTurlari_Click(object sender, EventArgs e)
        {
            TurGemiAnasayfa f7 = new TurGemiAnasayfa();
            this.Hide();
            f7.Show();
        }

        private void yurtdisiTurlari_Click(object sender, EventArgs e)
        {
            YurtDışıTurları f10 = new YurtDışıTurları();
            this.Hide();
            f10.Show();
        }

        private void girisYap_Click(object sender, EventArgs e)
        {
            girisyap grs = new girisyap();
            grs.ShowDialog();
        }

        private void kampanyalarButton_Click(object sender, EventArgs e)
        {
            kampanya kmp = new kampanya();
            this.Hide();
            kmp.ShowDialog();
        }

        private void turlarButton_Click(object sender, EventArgs e)
        {

        }

        private void turlarButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void otellerButton_Click(object sender, EventArgs e)
        {
            AnaSayfaOtel an = new AnaSayfaOtel();
            this.Hide();
            an.Show();
        }

        private void kampanyalarButton_Click_1(object sender, EventArgs e)
        {
            kampanya kmp = new kampanya();
            this.Hide();
            kmp.Show();
        }

        private void AnaSayfaTur_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            GirişSayfaları gsa = new GirişSayfaları();
            this.Hide();
            gsa.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            GirişSayfaları gsa = new GirişSayfaları();
            this.Hide();
            gsa.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş gs = new AnaSayfaGiriş();
            this.Hide();
            gs.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş gs = new AnaSayfaGiriş();
            this.Hide();
            gs.Show();
        }
    }
}
