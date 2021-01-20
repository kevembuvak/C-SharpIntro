using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //Furnitare
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {
                Id = 2,
                CategoryId = 5,
                ProductName = "Pencil",
                UnitPrice = 2,
                UnitsInStock = 5
            };

            ProductManager productManager = new ProductManager();

            productManager.ChangeName(product2);
            Console.WriteLine(product2.ProductName); //referans tipinde referans ile beraber yollarsın, o yüzden değişkenin değeri değişir

            int number = 100;
            productManager.DoStuff(number); // değer tipinde sadece 100 değeri yolluyosun, değişkenle bağlantı kesilir 
            Console.WriteLine(number);

            productManager.Sum2(3, 6); //yazdırır da
            productManager.Sum(3, 6);  //yazdırmaz sadece bi değer döndürür
        }
    }
}
