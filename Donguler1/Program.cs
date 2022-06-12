using System;

namespace Donguler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "C#";
            string kurs2 = "Java";
            string kurs3 = "python";
            string kurs4 = "Java Script";
            string kurs5 = "c++";
            string[] kurslar = new string[] { kurs1, kurs2, kurs3, kurs4, kurs5 };
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
