using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " isimli " + customer.AccountNo + " hesap numaralı müşteri eklendi.");
            Console.WriteLine("------------");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " isimli " + customer.AccountNo + " hesap numaralı müşteri silindi.");
            Console.WriteLine("------------");
        }
        public void List(Customer[] customerInfo)
        {
            foreach (var customer in customerInfo)
            {
                Console.WriteLine(customer.CustomerName + " isimli " + customer.AccountNo + " hesap numaralı müşteri listeye eklendi.");
            }

            Console.WriteLine("------------");
        }
    }
}