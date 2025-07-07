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
    public partial class richmond : Form
    {
        public richmond()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secimyap sc = new secimyap();
            this.Hide();
            sc.Show();

         }

        private void label6_Click(object sender, EventArgs e)
        {
            kampanya ka = new kampanya();
            this.Hide();
            ka.Show();
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

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            GirişSayfaları gi = new GirişSayfaları();
            this.Hide();
            gi.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            GirişSayfaları gi = new GirişSayfaları();
            this.Hide();
            gi.Show();
        }

        private void richmond_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Denize sıfır\nSpa \nÇocuk dostu: mini kulüp-bebek arabası - çocuk oyun alanı-çocuk bakıcısı\nMavi bayraklı\nSpor: mini futbol-fitness - dart - sörf - golf\nOtel olanakları:beach bar-sağlık hizmetleri - kuaför - kuru temizleme - solaryum");

        }
    }
}
