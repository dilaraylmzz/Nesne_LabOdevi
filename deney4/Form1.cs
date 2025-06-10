using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deney4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelGenislik_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelYukseklik_Click(object sender, EventArgs e)
        {

        }

        private void labelSekil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int g, y;
            if (int.TryParse(textBox1.Text, out g) && int.TryParse(textBox2.Text, out y))
            {
                Cokgen c;
                if (comboBox1.SelectedItem.ToString() == "Dortgen")
                {
                    c = new Dortgen2();
                }
                else
                {
                    c = new Ucgen();
                }

                c.DegerVer(g, y);
                labelSonuc.Text = Yazdir.Yaz(c);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayılar giriniz.");
            }
        }

        private void labelSonuc_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dortgen");
            comboBox1.Items.Add("Ucgen");
            comboBox1.SelectedIndex = 0;
        }
    }
}
