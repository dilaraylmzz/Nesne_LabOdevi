using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deney4
{
    public class Cokgen
    {
        protected int genislik, yukseklik;

        public void DegerVer(int g, int y)
        {
            genislik = g;
            yukseklik = y;
        }

        public virtual int Alan()
        {
            return 0;
        }

        public virtual string Sekil()
        {
            return "Cokgen";
        }
    }

    public class Dortgen2 : Cokgen
    {
        public override int Alan()
        {
            return genislik * yukseklik;
        }

        public override string Sekil()
        {
            return "Dortgen";
        }
    }

    public class Ucgen : Cokgen
    {
        public override int Alan()
        {
            return (genislik * yukseklik) / 2;
        }

        public override string Sekil()
        {
            return "Ucgen";
        }
    }

    public class Yazdir
    {
        public static string Yaz(Cokgen c)
        {
            return $"Sekil: {c.Sekil()} Alan: {c.Alan()}";
        }
    }
    internal class Sekiller
    {
    }
}
