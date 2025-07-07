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
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;

namespace Tatil_Rezervasyon_Otomasyonu
{
    public partial class kayit : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        DataSet ds;
        OleDbCommand cmd;
        public kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            girisyap gr = new girisyap();
            this.Hide();
            gr.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ap = new AnaSayfaGiriş();
            this.Hide();
            ap.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ap = new AnaSayfaGiriş();
            this.Hide();
            ap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Merve_Bayram\\Desktop\\Database2.accdb"))
            {
                string query = "INSERT INTO Tablo1 (Ad, Soyad, eposta, telefon, sifre, dtarihi) VALUES (@Ad, @Soyad, @eposta, @telefon, @sifre, @dtarihi)";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ad", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Soyad", textBox2.Text);
                    cmd.Parameters.AddWithValue("@eposta", textBox3.Text);
                    cmd.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@sifre", textBox1.Text);
                    cmd.Parameters.AddWithValue("@dtarihi", dogumtarihi.Value.ToString("yyyy-MM-dd"));

                    conn.Open();
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && maskedTextBox1.Text != "" && (radioButton3.Checked == true) )
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla yapıldı");
                        }

                        else
                        {
                            MessageBox.Show("Kayıt başarısız!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bilgileri eksiksiz girin!");
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {
            girisyap gs = new girisyap();
            this.Hide();
            gs.Show();
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

        private void kayit_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
