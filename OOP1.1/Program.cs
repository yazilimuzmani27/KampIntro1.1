using System;

namespace OOP1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5,UnitInStock = 5,ProductName = "Kalem",UnitPrice = 35};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            //ProductManager productManager2 = new ProductManager();
            //productManager2.Topla2(3,6);

            //int toplamaSonucu = productManager2.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);

            //int - double - bool .... değer tipleridir.
            //diziler - classlar - abstract classlar - interface - .... referans tipler.
        }
    }
}
