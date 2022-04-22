using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager/* Service => ürünle ilgili operasyonların olduğu
                         * dosyadır.*/ 
    {
        // encapsulation 
        public void Add(Product product) // 101
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int sayi1, int sayi2) 
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        //public void BiseyYap(int sayi)
        //{
        //    sayi = 99;
        //    Console.WriteLine(sayi);
        //}
    }
}

/** Void ne işe yarıyor :
 * Void emir kipi (git, yap, bitir)
 *  **/