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
    public partial class DedemanBostancıOtel : Form
    {
        public DedemanBostancıOtel()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        public void fillGrid()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Merve_Bayram\\Desktop\\OtelArama.accdb");
            da = new OleDbDataAdapter("Select OdaTipi, KişiSayısı, Ücret, Klima, Jakuzi from DedemanBostancıOtel", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "DedemanBostancıOtel");
            dataGridView1.DataSource = ds.Tables["DedemanBostancıOtel"];
            conn.Close();
        }
        private void DedemanBostancıOtel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yeni_Microsoft_Access_VeritabanıDataSet27.Dedeman_Bostancı_Otel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dedeman_Bostancı_OtelTableAdapter.Fill(this.yeni_Microsoft_Access_VeritabanıDataSet27.Dedeman_Bostancı_Otel);
            fillGrid();
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
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            YönetimOtelAnaSayfa yo = new YönetimOtelAnaSayfa();
            this.Hide();
            yo.Show();
        }
    }
}
