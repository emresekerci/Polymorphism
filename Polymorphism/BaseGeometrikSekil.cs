using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Base sınıf
    public class BaseGeometrikSekil
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        // Alan hesaplayan metot
        public virtual int AlanHesapla(int genislik, int yukseklik)
        {
            return genislik * yukseklik;
        }
    }

    // Kare sınıfı
    public class Kare : BaseGeometrikSekil
    {
        public override int AlanHesapla(int genislik, int yukseklik)
        {
            return base.AlanHesapla(genislik, yukseklik);
        }
    }

    // Dikdörtgen sınıfı
    public class Dikdortgen : BaseGeometrikSekil
    {
        public override int AlanHesapla(int genislik, int yukseklik)
        {
            return base.AlanHesapla(genislik, yukseklik);
        }
    }

    // Dik üçgen sınıfı
    public class DikUcgen : BaseGeometrikSekil
    {
        public override int AlanHesapla(int genislik, int yukseklik)
        {
            return (genislik * yukseklik) / 2;
        }
    }
}
