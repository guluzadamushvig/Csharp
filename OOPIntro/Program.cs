using System;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product {Id = 1, CategoryId = 4, ProductName = "T-shirt", UnitPrice = 10, UnitsInStock = 12 };
            //or
            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = 4;
            product2.ProductName = "Table";
            product2.UnitPrice = 76;
            product2.UnitsInStock = 34;


            ProductManager productManager = new ProductManager();

            productManager.Add(product1);
        }
    }
}
