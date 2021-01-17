using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer added successfully:" + customer.Name);
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer deleted successfully:" + customer.CustomerId);
        }
    }
}
