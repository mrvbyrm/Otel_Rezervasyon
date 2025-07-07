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
    public partial class kampanyadiamond : Form
    {
        public kampanyadiamond()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secimyap sc = new secimyap();
            this.Hide();
            sc.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Denize sıfır\nSpa \nÇocuk dostu: mini kulüp-bebek arabası - çocuk oyun alanı-çocuk bakıcısı\nMavi bayraklı\nSpor: mini futbol-fitness - dart - sörf - golf\nOtel olanakları:beach bar-sağlık hizmetleri - kuaför - kuru temizleme - solaryum");

        }
    }
}
