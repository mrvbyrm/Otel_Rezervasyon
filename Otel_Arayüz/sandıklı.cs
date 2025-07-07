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
    public partial class sandıklı : Form
    {
        public sandıklı()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş gs = new AnaSayfaGiriş();
            this.Hide();
            gs.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş gs = new AnaSayfaGiriş();
            this.Hide();
            gs.Show();
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            kampanya ka = new kampanya();
            this.Hide();
            ka.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secimyap se = new secimyap();
            this.Hide();
            se.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Denize sıfır\nSpa \nÇocuk dostu: mini kulüp-bebek arabası - çocuk oyun alanı-çocuk bakıcısı\nMavi bayraklı\nSpor: mini futbol-fitness - dart - sörf - golf\nOtel olanakları:beach bar-sağlık hizmetleri - kuaför - kuru temizleme - solaryum");
        }
    }
}
