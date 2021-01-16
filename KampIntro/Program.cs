using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip gvenliği - tanımlama yapmadan önce veri tipi belirtilmeli

            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            bool sistemeGirisYaptiMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (sistemeGirisYaptiMi) {
                Console.WriteLine("Kullanici Ayari Butonu");
            } else {
                Console.WriteLine("Giris Yap");
            }

            if (dolarDun > dolarBugun) {
                Console.WriteLine("Azalis");
            } else if (dolarDun < dolarBugun) {
                Console.WriteLine("Artis");
            } else {
                Console.WriteLine("Esit");
            }

        }
    }
}
