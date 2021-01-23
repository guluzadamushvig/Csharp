using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DailyCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Daily Credit payment plan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
