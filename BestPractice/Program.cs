using System;

namespace BestPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ders ders = new Ders();
            ders.Adi = "Elektronik";
            ders.Grade = 50;
            ders.Aciklama = "En zor ders";

            Ders ders1 = new Ders();
            ders1.Adi = "Motor";
            ders1.Grade = 60;
            ders1.Aciklama = "Motorun Temelleri";

            Ders ders3 = new Ders();
            ders3.Adi = "Yüksek Gerilim";
            ders3.Grade = 63;
            ders3.Aciklama = "Seçmeli Ders";

            Ders[] dersler = new Ders[] {ders1 , ders, ders3 };

            foreach (var lesson in dersler)
            {
                if (50<lesson.Grade)
                {
                    Console.WriteLine(lesson.Adi + " : Dersten Geçti");
                }
                else
                {
                    
                    DersManager Dersisim = new DersManager();
                    Dersisim.Kaldı(); 


                }
            }

        }
    }
}
