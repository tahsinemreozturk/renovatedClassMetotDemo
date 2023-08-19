using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        
            public void Add(Customer customer) 
            {
                Console.WriteLine(" Eklenen Musteri ====> " + "Musteri ID : " + customer.Id  +
                " Musteri Adi : " + customer.CustomerName  + " Musteri Yas: " + customer.CustomerAge +
                " Musteri Toplam Parasi : " + customer.CustomerTotalMoney);
                
            }
            public void Delete(Customer customer)
            {
                Console.WriteLine(" Silinen Musteri ====> " + "Musteri ID : " + customer.Id +
                " Musteri Adi : " + customer.CustomerName + " Musteri Yas: " + customer.CustomerAge +
                " Musteri Toplam Parasi : " + customer.CustomerTotalMoney);
                
            }
            
            public void Update(Customer customer)
            {
                Console.WriteLine(" Guncellenen Musteri ====> " + "Musteri ID : " + customer.Id +
                " Musteri Adi : " + customer.CustomerName + " Musteri Yas: " + customer.CustomerAge +
                " Musteri Toplam Parasi : " + customer.CustomerTotalMoney);
                
            }
            
        
    }
}
