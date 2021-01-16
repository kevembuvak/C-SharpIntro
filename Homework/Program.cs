using System;

namespace Homework
{
    class Products
    {
        public string Brand { get; set; }
        public int Cost { get; set; }
        public bool ShouldIGetIt { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Products keyboard = new Products();
            keyboard.Brand = "SteelSeries";
            keyboard.Cost = 500;
            keyboard.ShouldIGetIt = true;

            Products mouse = new Products();
            mouse.Brand = "Razer";
            mouse.Cost = 400;
            mouse.ShouldIGetIt = true;

            Products[] products = new Products[] { keyboard, mouse };

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ShouldIGetIt)
                {
                    Console.WriteLine("You should definitely see this one: " + products[i].Brand + " -------> " + products[i].Cost);
                }
            }

            foreach (Products product in products)
            {
                switch (product.ShouldIGetIt)
                {
                    case true:
                        Console.WriteLine("You should definitely see this one: " + product.Brand + " -------> " + product.Cost);
                        break;
                    case false:
                        break;
                }
            }

            int j = 0;
            while (j < products.Length)
            {
                switch (products[j].ShouldIGetIt)
                {
                    case true:
                        Console.WriteLine("You should definitely see this one: " + products[j].Brand + " -------> " + products[j].Cost);
                        break;
                    case false:
                        break;
                }

                j++;
            }

            
        }
    }
}
