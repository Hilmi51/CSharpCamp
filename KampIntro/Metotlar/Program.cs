namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();    
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            // Type-safe -- Tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Urun Idsi : "+ urun.Id);
                Console.WriteLine("Urun Adı : " + urun.Adi);
                Console.WriteLine("Urun Fiyatı : " + urun.Fiyati);
                Console.WriteLine("Urun Acıklaması : " + urun.Aciklama);
                Console.WriteLine("----------------------------------");
            }
          
            // instance - örnek
            // encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}

// Dont repeat yourself - DRY - Clean Code - Best Practice