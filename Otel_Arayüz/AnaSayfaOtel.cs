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
    public partial class AnaSayfaOtel : Form
    {
        public AnaSayfaOtel()
        {
            InitializeComponent();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            belirsizsayfa f = new belirsizsayfa();
            this.Close();
            f.Show();
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

        private void yurticiOteller_Click(object sender, EventArgs e)
        {
            yiciotel f2 = new yiciotel();
            this.Hide();
            f2.Show();
        }

        private void yurtdisiOteller_Click(object sender, EventArgs e)
        {
            ydısıotel f4 = new ydısıotel();
            this.Hide();
            f4.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void turlarButton_Click(object sender, EventArgs e)
        {
            AnaSayfaTur at = new AnaSayfaTur();
            this.Hide();
            at.Show();
        }

        private void kampanyalarButton_Click_1(object sender, EventArgs e)
        {
            kampanya km = new kampanya();
            this.Hide();
            km.Show();
        }

        private void label11_Click_1(object sender, EventArgs e)
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

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
                }

        private void label2_Click_1(object sender, EventArgs e)
        {
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
        }
    }
}
