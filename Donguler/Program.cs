using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //döngüler
            //birbirine benzeyen islemleri tekrar etmek
            //kurslari göstermek

            /*
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";  */

            //array - dizi
            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi", "Programlamaya baslangic icin temel kurs", "Java" , "Python"};


            for (int i = 0; i < kurslar.Length; i++ )
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n----Bir de foreach ile deneyelim----\n");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("\nsayfa sonu");
        }
    }
}
