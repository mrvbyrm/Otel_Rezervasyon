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
    public partial class TurYurtDışıBalkan : Form
    {
        public TurYurtDışıBalkan()
        {
            InitializeComponent();
        }

        private void tur1incele_Click(object sender, EventArgs e)
        {
            TurYurtDışıBalkanÖrnekk2 f21 = new TurYurtDışıBalkanÖrnekk2();
            f21.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TurYurtDışıBalkanÖrnek f22 = new TurYurtDışıBalkanÖrnek();
            f22.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            YurtDışıTurları b = new YurtDışıTurları();
            this.Hide();
            b.Show();
        }

        private void Form20_Load(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş aa = new AnaSayfaGiriş();
            this.Hide();
            aa.Show();
        }

        private void label3_Click(object sender, EventArgs e)
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
    }
}
