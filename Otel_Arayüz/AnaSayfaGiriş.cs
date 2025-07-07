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
    public partial class AnaSayfaGiriş : Form
    {
        int i = 0, j = 0;
        public AnaSayfaGiriş()
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

        private void otellerButton_Click(object sender, EventArgs e)
        {
            AnaSayfaOtel f6 = new AnaSayfaOtel();
            this.Hide();
            f6.Show();
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

        private void otelAra_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Algedra Otel")
            {
                AlgedraOtel algedraOtel = new AlgedraOtel();
                this.Hide();
                algedraOtel.Show();
            }
            if (textBox1.Text == "Alina Otel")
            {
                AlinaOtel alinaOtel = new AlinaOtel();
                this.Hide();
                alinaOtel.Show();
            }
            if (textBox1.Text == "Dedeman Bostancı Otel")
            {
                DedemanBostancıOtel dedeman = new DedemanBostancıOtel();
                this.Hide();
                dedeman.Show();
            }
            if (textBox1.Text == "Demirci Otel")
            {
                DemirciOtel demirciOtel = new DemirciOtel();
                this.Hide();
                demirciOtel.Show();
            }
            if (textBox1.Text == "Meiser Otel")
            {
                MeisserOtel meiserOtel = new MeisserOtel();
                this.Hide();
                meiserOtel.Show();
            }
            if (textBox1.Text == "Navakitel Otel")
            {
                NavakitelOtel navakitel = new NavakitelOtel();
                this.Hide();
                navakitel.Show();
            }
            if (textBox1.Text == "Reno Otel")
            {
                RenoOtel renoOtel = new RenoOtel();
                this.Hide();
                renoOtel.Show();
            }
            if (textBox1.Text == "The Marmara Pera Otel")
            {
                TheMarmaraPeraOtel peraOtel = new TheMarmaraPeraOtel();
                peraOtel.Show();
                this.Hide();
            }
            if (textBox1.Text == "Yurt İçi Otel")
            {
                yiciotel peraOtel = new yiciotel();
                peraOtel.Show();
                this.Hide();
            }
            if (textBox1.Text == "Yurtiçi Otel")
            {
                yiciotel peraOtel = new yiciotel();
                peraOtel.Show();
                this.Hide();
            }
            if (textBox1.Text == "Yurtiçi Oteller")
            {
                yiciotel peraOtel = new yiciotel();
                peraOtel.Show();
                this.Hide();
            }
            if (textBox1.Text == "yurtiçi oteller")
            {
                yiciotel peraOtel = new yiciotel();
                peraOtel.Show();
                this.Hide();
            }
            if (textBox1.Text == "yurtiçi otel")
            {
                yiciotel peraOtel = new yiciotel();
                peraOtel.Show();
                this.Hide();
            }
            if (textBox1.Text == "Yurt Dışı Otel")
            {
                ydısıotel peraOtel = new ydısıotel();
                peraOtel.Show();
                this.Hide();
            }
            if (textBox1.Text == "Yurtdışı Otel")
            {
                ydısıotel peraOtel = new ydısıotel();
                peraOtel.Show();
                this.Hide();
            }
            if (textBox1.Text == "yurtdışı oteller")
            {
                ydısıotel peraOtel = new ydısıotel();
                peraOtel.Show();
                this.Hide();
            }
            if (textBox1.Text == "Yurtdışı Oteller")
            {
                ydısıotel peraOtel = new ydısıotel();
                peraOtel.Show();
                this.Hide();
            }
            if (textBox1.Text == "yurtdışı otel")
            {
                ydısıotel peraOtel = new ydısıotel();
                peraOtel.Show();
                this.Hide();
            }
            if (textBox1.Text == "Otel")
            {
                OtelAnasayfa peraOtel = new OtelAnasayfa();
                peraOtel.Show();
                this.Hide();
            }
            if (textBox1.Text == "otel")
            {
                OtelAnasayfa peraOtel = new OtelAnasayfa();
                peraOtel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Aradığınız Sonuç Bulunamadı.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            GirişSayfaları gsa = new GirişSayfaları();
            this.Hide();
            gsa.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            GirişSayfaları gsa = new GirişSayfaları();
            this.Hide();
            gsa.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            j++;
            textBox5.Text = j.ToString();
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

        private void kampanyalarButton_Click(object sender, EventArgs e)
        {
            kampanya ka = new kampanya();
            this.Hide();
            ka.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş aa = new AnaSayfaGiriş();
            this.Hide();
            aa.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            AnaSayfaGiriş aa = new AnaSayfaGiriş();
            this.Hide();
            aa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Yunan Adaları Gemi Turu")
            {
                TurGemi f8 = new TurGemi();
                this.Hide();
                f8.Show();
            }
            if (textBox3.Text == "Yunan Adaları Gemi Turları")
            {
                TurGemi f8 = new TurGemi();
                this.Hide();
                f8.Show();
            }
            if (textBox3.Text == "Yunan Gemi Turu")
            {
                TurGemi f8 = new TurGemi();
                this.Hide();
                f8.Show();
            }
            if (textBox3.Text == "yunan gemi turu")
            {
                TurGemi f8 = new TurGemi();
                this.Hide();
                f8.Show();
            }
            if (textBox3.Text == "yunan gemi turları")
            {
                TurGemi f8 = new TurGemi();
                this.Hide();
                f8.Show();
            }
            if (textBox3.Text == "Mısır Turu")
            {
                TurlarMısır TM = new TurlarMısır();
                this.Hide();
                TM.Show();
            }
            if (textBox3.Text == "Mısır Turları")
            {
                TurlarMısır TM = new TurlarMısır();
                this.Hide();
                TM.Show();
            }
            if (textBox3.Text == "mısır turu")
            {
                TurlarMısır TM = new TurlarMısır();
                this.Hide();
                TM.Show();
            }
            if (textBox3.Text == "Akdeniz Gemi Turu")
            {
                TurInceleGemi akdeniz = new TurInceleGemi();
                this.Hide();
                akdeniz.Show();
            }
            if (textBox3.Text == "Karadeniz Turları")
            {
                TurKültürKaradeniz karadeniz = new TurKültürKaradeniz();
                this.Hide();
                karadeniz.Show();
            }
            if (textBox3.Text == "Ege Akdeniz Turları")
            {
                TurKültürEge ege = new TurKültürEge();
                this.Hide();
                ege.Show();
            }
            if (textBox3.Text == "Ege Akdeniz Turu")
            {
                TurKültürEge ege = new TurKültürEge();
                this.Hide();
                ege.Show();
            }
            if (textBox3.Text == "Akdeniz Turları")
            {
                TurKültürEge ege = new TurKültürEge();
                this.Hide();
                ege.Show();
            }
            if (textBox3.Text == "Akdeniz Turu")
            {
                TurKültürEge ege = new TurKültürEge();
                this.Hide();
                ege.Show();
            }
            if (textBox3.Text == "ege akdeniz turları")
            {
                TurKültürEge ege = new TurKültürEge();
                this.Hide();
                ege.Show();
            }
            if (textBox3.Text == "akdeniz turları")
            {
                TurKültürEge ege = new TurKültürEge();
                this.Hide();
                ege.Show();
            }
            if (textBox3.Text == "Ege Turları")
            {
                TurKültürEge ege = new TurKültürEge();
                this.Hide();
                ege.Show();
            }
            if (textBox3.Text == "Ege Turu")
            {
                TurKültürEge ege = new TurKültürEge();
                this.Hide();
                ege.Show();
            }
            if (textBox3.Text == "ege turu")
            {
                TurKültürEge ege = new TurKültürEge();
                this.Hide();
                ege.Show();
            }
            if (textBox3.Text == "ege turları")
            {
                TurKültürEge ege = new TurKültürEge();
                this.Hide();
                ege.Show();
            }
            if (textBox3.Text == "Kültür Turu")
            {
                TurlarKültür navakitel = new TurlarKültür();
                this.Hide();
                navakitel.Show();
            }
            if (textBox3.Text == "kültür turu")
            {
                TurlarKültür navakitel = new TurlarKültür();
                this.Hide();
                navakitel.Show();
            }
            if (textBox3.Text == "Balkan Turu")
            {
                TurYurtDışıBalkan renoOtel = new TurYurtDışıBalkan();
                this.Hide();
                renoOtel.Show();
            }
            if (textBox3.Text == "Gemi Turu")
            {
                TurGemiAnasayfa peraOtel = new TurGemiAnasayfa();
                this.Hide();
                peraOtel.Show();
               
            }
            if (textBox3.Text == "Yurt Dışı Turu")
            {
                YurtDışıTurları peraOtel = new YurtDışıTurları();
                this.Hide();
                peraOtel.Show();
            }
            if (textBox3.Text == "Yurtdışı Turu")
            {
                YurtDışıTurları peraOtel = new YurtDışıTurları();
                this.Hide();
                peraOtel.Show();
            }
            if (textBox3.Text == "yurtdışı turu")
            {
                YurtDışıTurları peraOtel = new YurtDışıTurları();
                this.Hide();
                peraOtel.Show();
            }
            if (textBox3.Text == "tur")
            {
                TurAnaSayfa peraOtel = new TurAnaSayfa();
                this.Hide();
                peraOtel.Show();
            }
            if (textBox3.Text == "Tur")
            {
                TurAnaSayfa peraOtel = new TurAnaSayfa();
                this.Hide();
                peraOtel.Show();
            }
            else
            {
                MessageBox.Show("Aradığınız Sonuç Bulunamadı.");
            }
        }

        private void AnaSayfaGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
