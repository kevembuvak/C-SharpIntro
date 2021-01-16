using System;
using System.Collections.Generic;
using System.Text;

namespace Metods
{
    class CartManager
    {
        public void AddToCart(Product product)
        {
            Console.WriteLine(product.Name + " Sepete Eklendi");
        }

        public void AddToCartAlternative(string productName, string productStatement, double productCost)
        {
            Console.WriteLine(productName + " Sepete Eklendi");
        }

    }
}
