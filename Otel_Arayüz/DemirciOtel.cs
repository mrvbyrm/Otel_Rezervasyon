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
    public partial class DemirciOtel : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public DemirciOtel()
        {
            InitializeComponent();
        }
        public void fillGrid()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Merve_Bayram\\Desktop\\OtelArama.accdb");
            da = new OleDbDataAdapter("Select OdaTipi, KişiSayısı, Ücret, Klima, Jakuzi from RenoOtel", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "RenoOtel");
            dataGridView1.DataSource = ds.Tables["RenoOtel"];
            conn.Close();
        }

        private void DemirciOtel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yeni_Microsoft_Access_VeritabanıDataSet12.Demirci_Otel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.demirci_OtelTableAdapter.Fill(this.yeni_Microsoft_Access_VeritabanıDataSet12.Demirci_Otel);
            fillGrid();
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş ag = new AnaSayfaGiriş();
            this.Hide();
            ag.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            YönetimOtelAnaSayfa yo = new YönetimOtelAnaSayfa();
            this.Hide();
            yo.Show();
        }
    }
}
