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
    public partial class TurlarKültür : Form
    {
        public TurlarKültür()
        {
            InitializeComponent();
        }

        private void karadenizTurlari_Click(object sender, EventArgs e)
        {
            TurKültürKaradeniz f4 = new TurKültürKaradeniz();
            this.Hide();
            f4.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TurKültürEge f13 = new TurKültürEge();
            this.Hide();
            f13.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void girisYap_Click(object sender, EventArgs e)
        {
            girisyap grs = new girisyap();
            this.Hide();
            grs.Show();
        }

        private void kampanyalarButton_Click(object sender, EventArgs e)
        {
            kampanya kmp = new kampanya();
            this.Hide();
            kmp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TurAnaSayfa ta = new TurAnaSayfa();
            this.Hide();
            ta.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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

        private void kampanyalarButton_Click_1(object sender, EventArgs e)
        {
            kampanya ka = new kampanya();
            this.Hide();
            ka.Show();
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

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş aa = new AnaSayfaGiriş();
            this.Hide();
            aa.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş aa = new AnaSayfaGiriş();
            this.Hide();
            aa.Show();
        }
    }
}
