using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // int, decimal, float, double, bool == değer tip - tüm işler 'stack'te halledilir
            // string, array, class, interface == referans tip - stack'te tutulur ama değerleri 'heap'tedir


            // değer tiplerde, iki değişkeni eşitlersen sadece değeri alırsın, ikinci değişkenle ilişkini kesersin
            // mesela:
            // sayi1 = 10;
            // sayi2 = 30;
            // sayi1 = sayi2;
            // sayi2 = 65;
            // en sonda sayi1 = 30 olur çünkü bağlantı devam etmiyor


            // referans tiplerinde, stack'te adres oluşturulur ve değerler heap'te, o yüzden sayilar1 = sayilar2 dediğin
            // anda referans numaralarını eşitlersin, hem sayilar1 hem sayilar2 aynı heap değerlerini tutar
            // sayilar1 = [1, 2, 3]
            // sayilar2 = [4, 5, 6]
            // sayilar1 = sayilar2
            // sayilar2[0] = 50
            // bundan sonra sayilar1[0] da 50 olur, aynı referansa sahipler çünkü, aynı değerlere bakıyolar 
        }
    }
}
