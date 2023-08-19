using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Baha Taskin";
            customer1.CustomerAge = 19;
            customer1.Id = 1;
            customer1.CustomerTotalMoney = 12678;

            Customer customer2 = new Customer();
            customer2.CustomerName = "Emre Ozturk";
            customer2.CustomerAge = 21;
            customer2.Id = 2;
            customer2.CustomerTotalMoney = 11500;

            Customer customer3 = new Customer();
            customer3.CustomerName = "Yakup Karakaya";
            customer3.CustomerAge = 39;
            customer3.Id = 3;
            customer3.CustomerTotalMoney = 150000;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            customerManager.Update(customer1);
            customerManager.Update(customer2);
            customerManager.Update(customer3);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
