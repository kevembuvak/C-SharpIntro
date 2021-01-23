using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerLoanManager consumerLoanManager = new ConsumerLoanManager();
            consumerLoanManager.Calculate();

            VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
            vehicleLoanManager.Calculate();

            MortgageManager mortgageManager = new MortgageManager();
            mortgageManager.Calculate();

            ICreditManager consumerLoanManager2 = new ConsumerLoanManager();
            consumerLoanManager.Calculate();

            ICreditManager vehicleLoanManager2 = new VehicleLoanManager();
            vehicleLoanManager.Calculate();

            ICreditManager mortgageManager2 = new MortgageManager();
            mortgageManager.Calculate();

            // Interface olarak oluşturmak da aynı işlevi görür, interface onu inheritance eden classları tutabilir

            ILoggerService databaseLoggerManager = new DatabaseLoggerManager();
            ILoggerService fileLoggerManager = new FileLoggerManager();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(consumerLoanManager, new List<ILoggerService> { new DatabaseLoggerManager(), new FileLoggerManager() });  ;
            applicationManager.Apply(vehicleLoanManager, new List<ILoggerService>());
            applicationManager.Apply(mortgageManager, new List<ILoggerService>());
            applicationManager.Apply(consumerLoanManager2, new List<ILoggerService>());
            applicationManager.Apply(vehicleLoanManager2, new List<ILoggerService>());
            applicationManager.Apply(mortgageManager2, new List<ILoggerService>());


            Console.WriteLine("\n\n\n\n -------------------------------- \n\n\n\n");


            List<ICreditManager> credits = new List<ICreditManager>() { };
            credits.Add(consumerLoanManager2);
            credits.Add(vehicleLoanManager2);

            applicationManager.InformAboutCredit(credits);
        }
    }
}
