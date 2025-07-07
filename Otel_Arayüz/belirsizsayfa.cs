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
    public partial class belirsizsayfa : Form
    {
        /*OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;*/

        int i = 0, j = 0;
        public belirsizsayfa()
        {
            InitializeComponent();
            otelArama.BackColor = SystemColors.Window;
            turArama.BackColor = SystemColors.GrayText;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void turlarButton_Click(object sender, EventArgs e)
        {
            AnaSayfaTur f2 = new AnaSayfaTur();
            this.Hide();
            f2.Show();
        }

        private void turArama_Click(object sender, EventArgs e)
        {
            otelArama.BackColor = SystemColors.GrayText;
            turArama.BackColor = SystemColors.Window;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }
        private void otelArama_Click(object sender, EventArgs e)
        {
            otelArama.BackColor = SystemColors.Window;
            turArama.BackColor = SystemColors.GrayText;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void otellerButton_Click(object sender, EventArgs e)
        {
            AnaSayfaOtel f6 = new AnaSayfaOtel();
            this.Hide();
            f6.Show();
        }

        private void kampanyalarButton_Click(object sender, EventArgs e)
        {
            kampanya kmp = new kampanya();
            this.Hide();
            kmp.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            textBox2.Text = i.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            textBox2.Text = i.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            j--;
            textBox5.Text = j.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            i++;
            textBox2.Text = i.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            i--;
            textBox2.Text = i.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            j++;
            textBox5.Text = j.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            j--;
            textBox5.Text = j.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            girisyap nm = new girisyap();
            this.Hide();
            nm.Show();
        }

        private void otellerButton_Click_1(object sender, EventArgs e)
        {
            AnaSayfaOtel aotel = new AnaSayfaOtel();
            this.Hide();
            aotel.Show();
        }

        private void otelAra_Click(object sender, EventArgs e)
        {

            /*conn = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Users\\Merve_Bayram\\Desktop\\Yeni Microsoft Access Veritabanı.accdb");
            da = new OleDbDataAdapter("Select * from YurtİciOteller where Şehir", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "YurtİciOteller");
            dataGridView1.DataSource = ds.Tables["YurtİciOteller"];
            conn.Close();*/
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void turlarButton_Click_1(object sender, EventArgs e)
        {

            AnaSayfaTur ast = new AnaSayfaTur();
            this.Hide();
            ast.Show();
            
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void kampanyalarButton_Click_1(object sender, EventArgs e)
        {
            kampanya kmpny = new kampanya();
            this.Hide();
            kmpny.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            j++;
            textBox5.Text = j.ToString();
        }
    }
}
