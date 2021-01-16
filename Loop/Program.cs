using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            string kurs1 = "Yazilim Gelistirme Kampi";
            string kurs2 = "Programlama Icin Temel Kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazilim Gelistirme Kampi", "Programlama Icin Temel Kurs", "Java", kurs1, kurs2, kurs3 };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n\nSayfa Sonu\n\n");

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n\n");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
