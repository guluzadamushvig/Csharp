using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //SO - L - ID
            
            //Mushvig - PersonCustomer
            PersonCustomer customer1 = new PersonCustomer();

            customer1.CustomerNo = "12345";
            customer1.Name = "Mushvig";
            customer1.SName = "Guluzada";
            customer1.TcNo = "1234556";
            customer1.Id = 1;

            //HTB LLC - CompanyCustomer

            CompanyCustomer customer2 = new CompanyCustomer();

            customer2.CustomerNo = "12345";
            customer2.CompanyName = "HTB LLC";
            customer2.TaxNo = "12345666";
            customer2.Id = 2;




        }
    }
}
