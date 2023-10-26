using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Bursa";
            customer.Id = 1;
            customer.LastName = "Bircan";
            customer.FirstName = "Rümeysa";

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Eylül Ada", LastName = "Bircan"
            };

            Console.WriteLine(customer2.FirstName);


            Console.ReadLine();
        }
    }
}
