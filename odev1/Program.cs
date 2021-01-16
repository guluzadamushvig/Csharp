using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Category = "Clothes";
            product1.Name = "Jeans";
            product1.Price = 23.5;

            Product product2 = new Product();
            product2.Category = "Electronics";
            product2.Name = "Phone";
            product2.Price = 2655;

            Product product3 = new Product();
            product3.Category = "Furniture";
            product3.Name = "Table";
            product3.Price = 55;

            Product[] products =new Product[]{ product1,product2,product3 };
            ///for
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(products[i].Name + " " + products[i].Price+ " " + products[i].Category);
            }

            Console.WriteLine("for ended");

            ///for each

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + " " + product.Price + " " + product.Category);
            }

            Console.WriteLine("foreach ended");


            /////while
            int j = 0;
            while (j < 3)
            {
                Console.WriteLine(products[j].Name + " " + products[j].Price + " " + products[j].Category);
                j++;
            }

        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
}
