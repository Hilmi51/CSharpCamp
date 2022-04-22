using System;

namespace KampIntro {
    class Program{
        static void Main(string[] args) {
            //Type safety = Tip güvenliği 
            //!! C# typesafe bir dildir !!
            //Değer Tutucu , alias 
            //Sözel veri tipleri string kullanılır.
            string kategoriEtiketi = "Kategoriler";

            //Sayısal veri tipleri int
            int ogrenciSayisi = 32000;

            /*Ondalıklı sayıları double ile veriyoruz*/
            double faizOranı = 1.45;

            bool sistemeGirisYapmisMi = true; /*Burası gerçek projelerde veri tabanlarından gelir*/

            // Şart blokları
            if (sistemeGirisYapmisMi == true) {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else {
                Console.WriteLine("Giriş yap butonu");
            }


            double dolarDun = 7.55;
            double dolarBugün = 7.55;

            if (dolarDun > dolarBugün)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugün)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Eşittir butonu");
            }

            //!!! DO NOT REPEAT YOURSELF = KENDİNİ TEKRARLAMA !!!
            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}

