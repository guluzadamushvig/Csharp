using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Customer
    {
        public Customer()
        {

        }

        public Customer(int id, string name, string sname)
        {
            Id = id;
            Name = name;
            SName = sname;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SName { get; set; }

    }
}
