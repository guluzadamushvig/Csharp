using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager dailyCreditManager = new DailyCreditManager();
            ICreditManager carCreditManager = new CarCreditManager(); 
            ICreditManager houseCreditManager = new HouseCreditManager(); // HouseCreditManager houseCreditManager = new HouseCreditManager();   - same thing

            ApplyForCreditManager applyForCreditManager = new ApplyForCreditManager();
            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();
            applyForCreditManager.Apply(carCreditManager, databaseLoggerService);


            List<ICreditManager> credits = new List<ICreditManager>() {dailyCreditManager, carCreditManager}; //customer ask for montly payment then employee selects from UI

            //applyForCreditManager.GiveCreditInformation(credits);
        }
    }
}
