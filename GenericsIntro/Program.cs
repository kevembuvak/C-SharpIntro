using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Kerem");
            Console.WriteLine(names.Length);
            names.Add("Burak");
            Console.WriteLine(names.Length);

            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
