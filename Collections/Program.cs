using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // arraylerde 4 değer tanımlandıysa, 5. değeri atayamazsın. tanımlama kısmında eklemen gerekir
            List<String> names = new List<String> {"Hello", "World" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            names.Add("!");
            Console.WriteLine(names[2]);
        }
    }
}
