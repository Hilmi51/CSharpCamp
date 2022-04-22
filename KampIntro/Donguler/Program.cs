using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
            */

            // Array - dizi
            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python", "C++" };

            // Döngüler birşeyleri tekrar etmek için kullanılan yapılardır.
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti...");

            // Dizi temelli yapıları tek tek dönmeye yarıyor. (foreach)
            foreach (string kurs in kurslar) // Kursları dolaş... 
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
