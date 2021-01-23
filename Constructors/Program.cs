using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            ////first use

            customer.Id = 1;
            customer.Name = "Mushvig";
            customer.SName = "Guluzada";

            ////second use

            Customer customer2 = new Customer() { Id = 2, Name = "Nigar", SName = "Guluzada" };


            //// third use

            Customer customer3 = new Customer(3,"Arslan","Guluzada");
        }
    }
}
