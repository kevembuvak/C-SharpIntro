using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Oranı Hesaplandı");
        }

        public void DoStuff()
        {
            throw new NotImplementedException();
        }
    }
}
