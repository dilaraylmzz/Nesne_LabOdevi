using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deney3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestDortgenler_Click(object sender, EventArgs e)
        {
            // 1. Varsayılan kurucu ile Dortgen oluşturma
            Dortgen d1 = new Dortgen();
            lblSonuc1.Text = $"d1 (Varsayılan): x={d1.x}, y={d1.y}, Alan={d1.Alan()}";

            // 2. Parametreli kurucu ile Dortgen oluşturma
            Dortgen d2 = new Dortgen(5, 7);
            lblSonuc2.Text = $"d2 (Parametreli): x={d2.x}, y={d2.y}, Alan={d2.Alan()}";

            // 3. Kopyalama kurucu ile Dortgen oluşturma ve DegerVer metodunu kullanma
            Dortgen d3 = new Dortgen(d2); // d2'nin kopyasını oluşturur
            d3.DegerVer(10, 4); // d3'ün değerlerini değiştirir
            lblSonuc3.Text = $"d3 (Kopyalanmış ve Değer Verilmiş): x={d3.x}, y={d3.y}, Alan={d3.Alan()}";

            // 4. Buyuk metodunu kullanarak büyük olanı bulma
            Dortgen enBuyukDortgen = d1.Buyuk(d2);
            MessageBox.Show($"d1 ve d2'den büyük olanın alanı: {enBuyukDortgen.Alan()}", "En Büyük Dikdörtgen");

            // d3 ve d2 arasındaki farkı göstermek için d2'nin alanını tekrar gösterelim
            // (d3'ü değiştirmek d2'yi etkilemez)
            MessageBox.Show($"d2'nin alanı hala: {d2.Alan()}", "d2 Alanı Kontrol");
        }
    }
}
