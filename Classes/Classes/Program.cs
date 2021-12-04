using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            Customer customer = new Customer();
            customer.id = 1;
            customer.firstName = "Yücel";
            customer.lastName = "Sarıkaya";
            customer.city = "Ankara";
            Console.WriteLine(customer.firstName);

            Console.WriteLine("Main çalıştı");
            Console.ReadLine(); 
        }
    }
}