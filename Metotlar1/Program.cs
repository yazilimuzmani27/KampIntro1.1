using System;

namespace Metotlar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi1 = "Elma";
            double Fiyati1 = 15;
            string Aciklama1 = "Amasya Elması";

            string[] meyveler = new string[] { };
            
            Product product1 = new Product();            
            product1.Adi = "Elma";
            product1.Aciklama = "Amasya Elmas";
            product1.Fiyati = 15;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.Fiyati = 80;

            Product[] products = new Product[] { product1, product2 };
            //for (int i=0 ; i <=products.Length; i++)
            //{
            //    Console.WriteLine(products[i].Adi);
            //    Console.WriteLine(products[i].Fiyati);
            //}
            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
            }
            Console.WriteLine("**************************");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 15);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 18);

        }
    }
}


//Do not repeat yourself - DRY 