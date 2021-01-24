using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer { CustomerId = 123, CustomerName = "Ahmet", CustomerAge = 30, AccountNo = 123456 };
            Customer customer2 = new Customer { CustomerId = 456, CustomerName = "Mehmet", CustomerAge = 40, AccountNo = 456789 };
            Customer customer3 = new Customer { CustomerId = 789, CustomerName = "Hasan", CustomerAge = 20, AccountNo = 654321 };
            Customer customer4 = new Customer { CustomerId = 246, CustomerName = "Ayşe", CustomerAge = 25, AccountNo = 987654 };

            Customer[] customerArray = new Customer[] { customer1, customer2, customer3, customer4 };



            CustomerManager customerManager = new CustomerManager();
            customerManager.List (customerArray);
            customerManager.Delete(customer2);
            customerManager.Add(customer4);
            customerManager.Add(customer3);

            
            int campaignCustomerAge = 29;
            var customer = campaignCustomerAge>29 ? customer1.CustomerName + " ve " +customer2.CustomerName + " müşterileri kampanya dahilinde." : 
                customer3.CustomerName + " ve " + customer4.CustomerName + " müşterileri kampanya dahilinde.";
            Console.WriteLine(customer);
                     
        }
        
    }
}
