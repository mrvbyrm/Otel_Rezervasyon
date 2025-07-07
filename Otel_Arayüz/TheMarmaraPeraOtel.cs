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
    public partial class TheMarmaraPeraOtel : Form
    {
        public TheMarmaraPeraOtel()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        private void TheMarmaraPeraOtel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelAramaDataSet1.TheMarmaraPeraOtel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.theMarmaraPeraOtelTableAdapter.Fill(this.otelAramaDataSet1.TheMarmaraPeraOtel);
            fillGrid();
        }
        public void fillGrid()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Merve_Bayram\\Desktop\\OtelArama.accdb");
            da = new OleDbDataAdapter("Select OdaTipi, KişiSayısı, Ücret, Klima, Jakuzi from TheMarmaraPeraOtel", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "TheMarmaraPeraOtel");
            dataGridView1.DataSource = ds.Tables["TheMarmaraPeraOtel"];
            conn.Close();
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

        private void label2_Click(object sender, EventArgs e)
        {
            YönetimOtelAnaSayfa yo = new YönetimOtelAnaSayfa();
            this.Hide();
            yo.Show();
        }
    }
}
