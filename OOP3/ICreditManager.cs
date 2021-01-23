using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{

    // Interface'i, birbirinin alternatifi olan ama iç kodları farklı olan classları bir başlık altında toplayabilmek için yaparız

    // Interface bir şablondur, bunu inheritance eden her classta olması gereken metodları içerir

    interface ICreditManager // I ile başlar çünkü interface olduğu anlaşılsın
    {
        void Calculate();
        void DoStuff();
    }
}
