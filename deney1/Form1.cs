using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deney1
{
    public partial class Form1 : Form
    {
        const int GECMENOTU = 50;
        const int DERSSAYISI = 5;

        double[] dersnotlari = new double[DERSSAYISI];
        int yertutucu = 0;
        double dersnotu = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int vize) ||
                 !int.TryParse(textBox2.Text, out int finaln))
            {
                MessageBox.Show("Lütfen geçerli notlar girin.");
                return;
            }

            int ortalama = (int)(vize * 0.4 + finaln * 0.6);
            label3.Text = ortalama.ToString();

            if (ortalama >= GECMENOTU)
                label4.Text = "Geçti";
            else
                label4.Text = "Kaldı";

            if (ortalama < GECMENOTU)
                dersnotu = 0;
            else if (ortalama < 60)
                dersnotu = 1;
            else if (ortalama < 70)
                dersnotu = 2;
            else if (ortalama < 85)
                dersnotu = 3;
            else
                dersnotu = 4;

            label5.Text = dersnotu.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (yertutucu >= DERSSAYISI)
            {
                label6.Text = "Dizi doldu";
                return;
            }

            dersnotlari[yertutucu++] = dersnotu;
            label6.Text = "Eklendi";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            int gecenDersSayisi = 0;

            for (int i = 0; i < DERSSAYISI; i++)
            {
                if (dersnotlari[i] < 2.5)
                    continue;

                toplam += dersnotlari[i];
                gecenDersSayisi++;
            }

            if (gecenDersSayisi == 0)
            {
                label6.Text = "Geçen ders yok";
                return;
            }

            double donemOrt = toplam / gecenDersSayisi;
            label6.Text = "Dönem Ort: " + donemOrt.ToString("0.00");

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
