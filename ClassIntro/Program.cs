using System;

namespace ClassIntro
{
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 99;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.IzlenmeOrani = 23;

            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen + " ------> " + kurs1.IzlenmeOrani);

            Console.WriteLine("\n\n\n\n\n");

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (Kurs kursTakmaIsim in kurslar)
            {
                Console.WriteLine(kursTakmaIsim.KursAdi);
            }

        }
    }
}
