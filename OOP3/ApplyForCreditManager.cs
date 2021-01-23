using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyForCreditManager
    {
        public void Apply(ICreditManager creditManager,ILoggerService loggerService) // you can send HouseCredit or DailyCredit or CarCredit
        {
            // Getting Applier information
            //  ... .. . . . . 
            creditManager.Calculate();
            loggerService.Log();

        }

        public void GiveCreditInformation(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
