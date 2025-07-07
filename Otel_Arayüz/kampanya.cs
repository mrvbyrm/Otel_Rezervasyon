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
    public partial class kampanya : Form
    {
        public kampanya()
        {
            InitializeComponent();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş n = new AnaSayfaGiriş();
            this.Hide();
            n.Show();
        }

        private void kampanya_Load(object sender, EventArgs e)
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

        private void kampanyalarButton_Click(object sender, EventArgs e)
        {
            kampanya ka = new kampanya();
            this.Hide();
            ka.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş aK= new AnaSayfaGiriş();
            this.Hide();
            aK.Show();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            GirişSayfaları gsa = new GirişSayfaları();
            this.Hide();
            gsa.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            GirişSayfaları gsa = new GirişSayfaları();
            this.Hide();
            gsa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kampanyadiamond f1 = new kampanyadiamond();
            this.Hide();
            f1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Xandu xn = new Xandu();
            this.Hide();
            xn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sandıklı sa = new sandıklı();
            this.Hide();
            sa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richmond ri = new richmond();
            this.Hide();
            ri.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            nirvana Nİ = new nirvana();
            this.Hide();
            Nİ.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ngsapanca ng = new ngsapanca();
            this.Hide();
            ng.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kyrenia KY = new kyrenia();
            this.Hide();
            KY.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            sandıklı sa = new sandıklı();
            this.Hide();
            sa.Show();
        }
    }
}
