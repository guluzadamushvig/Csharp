using System;
using System.Collections.Generic;
using System.Text;

namespace Metods
{
    class CartManager
    {
        //name convention in c# = methods first name is capital letter
        //reusability
        public void Add(Product product)
        {
            Console.WriteLine("Added to cart!" + " "+ product.Name);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Deleted from cart! " + " "+ product.Name);
        }

    }
}
