using System;

namespace MustafaClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DersIsımleri Ders1 = new DersIsımleri();
            Ders1.DersIsmi = "Elektronik";
            Ders1.AlinanNot = 50;
            Ders1.KrediSayisi = 5;

            Console.WriteLine(Ders1.DersIsmi);
            Console.WriteLine(Ders1.AlinanNot);
            Console.WriteLine(Ders1.KrediSayisi);
        }
    }
}
