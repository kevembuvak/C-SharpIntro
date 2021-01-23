using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{

    // Inheritance -----> kalıtım, miras

    class RealCustomer: Customer
    {
        public string TcNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
