using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays
            string[] names = new string[] { "Mushvig", "Nigar", "Arslan" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            // we can't add additional element
            //for ex: names[3] = "Alparslan"; arrayOutOfBounds exception
            // array length is static when you initialize first


            Console.WriteLine("----------Array finished---------------------");
            /// ---------collections-----------
            List<string> names2 = new List<string>() { "Mushvig", "Nigar", "Arslan" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            names2.Add("Alparslan");

            foreach (string name in names2)
            {
                Console.WriteLine(name);
            }

        }
    }
}
