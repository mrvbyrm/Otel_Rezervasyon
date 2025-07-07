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
    public partial class girisyap : Form
    {
        public girisyap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Merve_Bayram\\Desktop\\Database2.accdb");
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand("select * from Tablo1 where eposta=@eposta and sifre=@sifre", baglanti);
            giris.Parameters.AddWithValue("@eposta", textBox2.Text);
            giris.Parameters.AddWithValue("@sifre", textBox1.Text);

            OleDbDataReader oku = giris.ExecuteReader();
            if (oku.Read())
            {
                AnaSayfaGiriş aa = new AnaSayfaGiriş();
                this.Hide();
                aa.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit kt = new kayit();
            this.Hide();
            kt.Show();
        }

        private void girisyap_Load(object sender, EventArgs e)
        {

        }

        private void girisyap_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'girisDataSet1.giris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.girisTableAdapter1.Fill(this.girisDataSet1.giris);
            // TODO: Bu kod satırı 'girisDataSet.giris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.girisTableAdapter.Fill(this.girisDataSet.giris);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox26_Click(object sender, EventArgs e)
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
    }
}
