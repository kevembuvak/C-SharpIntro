using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void ChangeName(Product product)
        {
            product.ProductName = "Camera";
        }

        public void DoStuff(int sayi)
        {
            sayi = 99;
        }

        public void Add(Product product)
        {
            Console.WriteLine("Added: " + product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Updated: " + product.ProductName);
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2; //Yazdırmaz, sadece değeri döndürür
        }

        public void Sum2(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
