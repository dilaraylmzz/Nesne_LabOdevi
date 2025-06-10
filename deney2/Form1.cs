using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deney2
{
    public partial class Form1 : Form
    {
        Random r = new Random(); // Rastgele nesnesi, tüm Form için bir kere tanımlanır.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 3, b = 7, c = 5;
            int enBuyuk = Maksimum(a, b, c);
            OrtakText.AppendText("En büyük: " + enBuyuk + "\r\n");

            // Değiştirme örneği
            Degistir2(ref a, ref b);
            OrtakText.AppendText($"a: {a}, b: {b}\r\n");

            // Yaz fonksiyonu
            Yaz(OrtakText);
            Yaz(OrtakText, "X");
            Yaz(OrtakText, "Y", 5);

            // Rastgele sayı
            int rastgele = SayiUret(1, 100);
            OrtakText.AppendText("Rastgele: " + rastgele + "\r\n");

            // Namespace değerleri
            int d1 = IsimUzayi1.Degerler.deger;
            int d2 = IsimUzayi2.Degerler.deger;
            OrtakText.AppendText($"İsimUzayı1: {d1}, İsimUzayı2: {d2}\r\n");
        }
        // ------------ Yardımcı metodlar burada ------------

        int Maksimum(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        void Degistir2(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        void Yaz(TextBox textBox)
        {
            textBox.AppendText("**********\r\n");
        }

        void Yaz(TextBox textBox, string s)
        {
            for (int i = 0; i < 10; i++)
                textBox.AppendText(s);
            textBox.AppendText("\r\n");
        }

        void Yaz(TextBox textBox, string s, int n)
        {
            for (int i = 0; i < n; i++)
                textBox.AppendText(s);
            textBox.AppendText("\r\n");
        }

        int SayiUret(int min, int max)
        {
            return r.Next(min, max);
        }

        private void OrtakText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
