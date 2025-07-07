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
    public partial class TurYurtDışıBalkanÖrnekk2 : Form
    {
        public TurYurtDışıBalkanÖrnekk2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            belirsizsayfa k = new belirsizsayfa();
            k.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            girisyap grs = new girisyap();
            grs.Show();
        }

        private void kampanyalarButton_Click(object sender, EventArgs e)
        {
            kampanya kmp = new kampanya();
            this.Hide();
            kmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secimyap sec = new secimyap();
            this.Hide();
            sec.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            TurYurtDışıBalkan fr = new TurYurtDışıBalkan();
            this.Hide();
            fr.Show();
        }

        private void Form21_Load(object sender, EventArgs e)
        {

        }

        private void otellerButton_Click(object sender, EventArgs e)
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

        private void kampanyalarButton_Click_1(object sender, EventArgs e)
        {
            OtelAnasayfa oa = new OtelAnasayfa();
            this.Hide();
            oa.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            AnaSayfaGiriş aa = new AnaSayfaGiriş();
            this.Hide();
            aa.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş aa = new AnaSayfaGiriş();
            this.Hide();
            aa.Show();
        }
    }
}
