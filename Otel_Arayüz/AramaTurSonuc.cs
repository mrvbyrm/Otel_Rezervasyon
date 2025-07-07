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
    public partial class AramaTurSonuc : Form
    {
        public AramaTurSonuc()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
        }

        private void AramaTurSonuc_Load(object sender, EventArgs e)
        {

        }
    }
}
