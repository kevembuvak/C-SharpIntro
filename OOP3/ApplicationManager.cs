using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        // Hangi sınıfın metodu kullanılması gerektiğini söylemeden bu şekilde yazılmasına Metod Injection denir
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices)  // ICreditManager kullanıyoruz çünkü her türlü kredi classını tutabilir
        {
            //
            //
            // Lots of code stuff
            //
            //

            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            // bunu diyebiliyorum çünkü hangi türlü kredi sınıfı gelirse gelsin o classın metodu çalışır
        }

        public void InformAboutCredit(List<ICreditManager> credits)
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }

    }
}
