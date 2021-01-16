using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Cost = 15;
            product1.Statement = "Red Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Cost = 80;
            product2.Statement = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Cost);
                Console.WriteLine(product.Statement);
                Console.WriteLine("--------------------------------");
            }

            CartManager cartManager = new CartManager();
            cartManager.AddToCart(product1);
            cartManager.AddToCartAlternative("", "", 6); //Ben yeni bi şey eklemek istesem hem metodu hem tüm reference'ları değiştirmek zorunda kalıcaktık, o yüzden class olarak parametre vermek daha iyi   -    encapsulation
        }
    }
}

//Do not repeat yourself     -     Clean Code     -     Best Practice