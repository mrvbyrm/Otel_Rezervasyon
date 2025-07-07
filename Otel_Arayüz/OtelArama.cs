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
    public partial class OtelArama : Form
    {
        public OtelArama()
        {
            InitializeComponent();
        }

        private void otelAra_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Algedra Otel")
            {
                AlgedraOtel algedraOtel = new AlgedraOtel();
                this.Hide();
                algedraOtel.Show();
            }
            if (comboBox1.Text == "Alina Otel")
            {
                AlinaOtel alinaOtel = new AlinaOtel();
                this.Hide();
                alinaOtel.Show();
            }
            if (comboBox1.Text == "Dedeman Bostancı Otel")
            {
                DedemanBostancıOtel dedeman = new DedemanBostancıOtel();
                this.Hide();
                dedeman.Show();
            }
            if (comboBox1.Text == "Demirci Otel")
            {
                DemirciOtel demirciOtel = new DemirciOtel();
                this.Hide();
                demirciOtel.Show();
            }
            if (comboBox1.Text == "Meiser Otel")
            {
                MeisserOtel meiserOtel = new MeisserOtel();
                this.Hide();
                meiserOtel.Show();
            }
            if (comboBox1.Text == "Navakitel Otel")
            {
                NavakitelOtel navakitel = new NavakitelOtel();
                this.Hide();
                navakitel.Show();
            }
            if (comboBox1.Text == "Reno Otel")
            {
                RenoOtel renoOtel = new RenoOtel();
                this.Hide();
                renoOtel.Show();
            }
            if (comboBox1.Text == "The Marmara Pera Otel")
            {
                TheMarmaraPeraOtel peraOtel = new TheMarmaraPeraOtel();
                peraOtel.Show();
                this.Hide();
            }
        }

        private void OtelArama_Load(object sender, EventArgs e)
        {

        }
    }
}
