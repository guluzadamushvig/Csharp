using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.Name = "Mushvig";
            customer.Sname = "Guluzada";
            customer.CustomerId = 1211111;

            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer);
            customerManager.DeleteCustomer(customer);
        }
    }
}
