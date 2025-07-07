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
    public partial class secimyap : Form
    {
        public secimyap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odeme ode = new odeme();
            this.Hide();
            ode.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            odeme ode = new odeme();
            this.Hide();
            ode.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            AnaSayfaGiriş ae= new AnaSayfaGiriş();
            this.Hide();
           ae.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ae = new AnaSayfaGiriş();
            this.Hide();
            ae.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ae = new AnaSayfaGiriş();
            this.Hide();
            ae.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
