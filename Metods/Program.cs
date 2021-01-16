using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            //product1.Id = 1;
            product1.Name = "Iphone";
            product1.Price = 599;
            product1.Description = "Mobile Phone";

            Product product2 = new Product();
            //product2.Id = 2;
            product2.Name = "TV";
            product2.Price = 1599;
            product2.Description = "LG TV";

            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price + "$");
                Console.WriteLine(product.Description);

                Console.WriteLine("-------------");
            }


            Console.WriteLine("---------Methods-----------");

            //instance
            CartManager cartManager = new CartManager();
            cartManager.Add(product1);


        }
    }
}


//Don't repeat yourself - DRY principe
//Write once use everywhere :) 
