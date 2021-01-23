using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer1 = new Customer();
            //customer1.Name = "Kerem";
            //customer1.Surname = "Yılmaz";
            //customer1.Id = 1;
            //customer1.TcNumber = "2222222";
            //customer1.CustomerNumber = "33333";
            //customer1.CompanyName = "????";

            // Eğer bir objeyle alakası olmayan bir prop varsa burda kalıtım kullanmak mantıklı olandır


            RealCustomer realCustomer = new RealCustomer();
            realCustomer.Id = 1;
            realCustomer.CustomerNo = "12345";
            realCustomer.Name = "Kerem Burak";
            realCustomer.Surname = "Yılmaz";
            realCustomer.TcNumber = "12346874";

            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.Id = 2;
            corporateCustomer.CustomerNo = "324342";
            corporateCustomer.CompanyName = "Kodlama.io";
            corporateCustomer.TaxNumber = "893472";

            Customer customer1 = new RealCustomer();                //parent sınıf iki child sınıfı da tutabilir
            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();   //şu anda hem RealCustomer hem CorporateCustomer gönderebilirim


        }
    }
}
