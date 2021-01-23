using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsumerLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Oranı Hesaplandı");
        }

        public void DoStuff()
        {
            throw new NotImplementedException();
        }
    }
}
