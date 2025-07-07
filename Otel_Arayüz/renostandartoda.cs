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
    public partial class renostandartoda : Form
    {
        public renostandartoda()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ydısıotel yo = new ydısıotel();
            this.Hide();
            yo.Show();
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

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            GirişSayfaları ag = new GirişSayfaları();
            this.Hide();
            ag.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odeme od = new odeme();
            this.Hide();
            od.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Açılabilir pencere\r\nBalkon\r\nBuzdolabı\r\nDuş\r\nDüz ekran TV\r\nElektrik su ısıtıcısı\r\nKablo TV\r\nKahve Makinesi\r\nKlima\r\nMerkezi ısıtma\r\nMikrodalga Fırın\r\nOda Kasası\r\nSaç kurutma makinası\r\nTelefon\r\nTelevizyon\r\nUydu TV\r\nWi-Fi\r\nÇalışma Masası\r\nÜcretsiz WiFi (odada)\r\nÜtü Masası");

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            GirişSayfaları sa = new GirişSayfaları();
            this.Hide();
            sa.Show();
        }
    }
}
