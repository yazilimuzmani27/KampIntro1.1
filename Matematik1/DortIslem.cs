using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik1
{
    internal class DortIslem
    {
        public void Topla(int sayi1 , int sayi2)
        {
            //önce eşitliğin sağ tarafı çalışır.
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}
