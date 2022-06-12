using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar1
{
    internal class SepetManager
    {
        //Naming - Convention
        public void Ekle(Product product )
        {
            Console.WriteLine("Sepete Eklendi" + product.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama , double Fiyat)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
