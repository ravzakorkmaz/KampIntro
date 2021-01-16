using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elmasi"; 
            */

            //Instanz aus Ürün
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("\n--------Metotlar--------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yesil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakir karpuzu", 12, 8);
        

        }
    }
}

//dont repeat yourself - DRY - Clean - Code - Best practise 

