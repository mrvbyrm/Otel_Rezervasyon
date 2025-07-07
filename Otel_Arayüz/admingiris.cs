using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tatil_Rezervasyon_Otomasyonu
{
    public partial class admingiris : Form
    {
        public admingiris()
        {
            InitializeComponent();
        }
        private void admingiris_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Merve_Bayram\\Desktop\\admin.accdb");
            
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand("select * from admin where Ad_soyad=@Ad_soyad and sifre=@sifre", baglanti);
            giris.Parameters.AddWithValue("@Ad_soyad", textBox2.Text);
            giris.Parameters.AddWithValue("@sifre", textBox1.Text);

            OleDbDataReader oku = giris.ExecuteReader();
            if (oku.Read())
            {
                YöneticiSistemi yo = new YöneticiSistemi();
                this.Hide();
                yo.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void admingiris_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            GirişSayfaları gsa = new GirişSayfaları();
            this.Hide();
            gsa.Show();
        }

        private void label14_Click(object sender, EventArgs e)
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
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
