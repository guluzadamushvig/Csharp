using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //dont repeat yourself(DRY)
            //alias takma ad
            //asd
            string kategoeiEtiketi = "Kateqotiler";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.76;
            bool sistemeGirmismi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis butonu");
            }

            else
            {
                Console.WriteLine("degismedi butonu");
            }
            if (sistemeGirmismi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoeiEtiketi);
        }
    }
}
