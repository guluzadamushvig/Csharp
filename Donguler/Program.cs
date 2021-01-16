using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Java", "charSharp", "Phyton" };


            // for (int i = 0; i < 3; i++)
            //{
            //   Console.WriteLine(kurslar[i]);
            //}


            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
