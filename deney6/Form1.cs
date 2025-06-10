using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deney6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 5, j = 8, k;
            float l = 4.2f, m = 6.7f, n;

            k = Karsilastirma.GetMax<int>(i, j);
            n = Karsilastirma.GetMax<float>(l, m);

            OrtakText.Text = "Max int: " + k.ToString() + "\r\n";
            OrtakText.Text += "Max float: " + n.ToString("0.0") + "\r\n";
        }
    }
}
