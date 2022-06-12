using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1
{
    internal class ProductManager
    {

        //void = git ekle git sil git güncelle emir kipinde çağırıyoruz ve işlemi yapıp bitiriyor böyle kullanımlarda void kullanılıyor.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " : Eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " : Güncellendi.");
        }

        //buradada sayıları toplayıp döndürmek için kullanıyoruz bu şekilde
        public int Topla(int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
           Console.WriteLine(sayi1 + sayi2);
        }
    }
}
