using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ev Kredisi Oranı Hesaplandı");
        }

        public void DoStuff()
        {
            throw new NotImplementedException();
        }
    }
}
