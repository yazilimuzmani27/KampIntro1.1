using System;

namespace KampIntro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategariEtiketi = "Kategoriler";
            int ogrenciSayisi = 230000;
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(kategariEtiketi);
            Console.WriteLine(kategariEtiketi);
            Console.WriteLine(kategariEtiketi);
            Console.WriteLine(kategariEtiketi);
            bool sistemeGirisYapmismi = false;

            if(sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Sisteme Giris yapmamis");    
            }
        }
    }
}
