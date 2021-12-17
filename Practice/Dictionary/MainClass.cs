using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
   public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class MainClass
    {
        static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 100,
                Name = "Bablu",
                Salary = 1000
            };
            Customer customer2 = new Customer()
            {
                ID = 111,
                Name = "rad",
                Salary = 3000
            };
            Customer customer3 = new Customer()
            {
                ID = 123,
                Name = "bss",
                Salary = 3000
            };
            Dictionary<int, Customer> customerDictionary = new Dictionary<int, Customer>();
            customerDictionary.Add(customer1.ID, customer1);
            customerDictionary.Add(customer2.ID, customer2);
            customerDictionary.Add(customer3.ID, customer3);

            if (!customerDictionary.ContainsKey(customer1.ID))
            {
                customerDictionary.Add(customer1.ID, customer1);
            }

            //if (customerDictionary.ContainsKey(111))
            //{
            //    Customer customerDetail = customerDictionary[111];
            //    Console.WriteLine("Id={0} Name={1} Salary={2}", customerDetail.ID, customerDetail.Name, customerDetail.Salary);
            //}
           
            

            //foreach (var customer in customerDictionary)
            //{
            //    Console.WriteLine("Key = {0}", customer.Key);
            //    Console.WriteLine("Customer details:");
            //    Customer cus = customer.Value;
            //    Console.WriteLine("Id={0} Name={1} Salary={2}", cus.ID, cus.Name, cus.Salary);
            //    Console.WriteLine("-----------------------------------------------------");
            //}

            //Retrive only value from dictionary
            //foreach(Customer cus in customerDictionary.Values)
            //{
            //    Console.WriteLine("Id={0} Name={1} Salary={2}", cus.ID, cus.Name, cus.Salary);
            //}
            

            //TryGetValue method

            if(customerDictionary.TryGetValue(111,out Customer cust))
            {
                Console.WriteLine("Id={0} Name={1} Salary={2}", cust.ID, cust.Name, cust.Salary);
            }
            else
            {
                Console.WriteLine("Key is not found");
            }


            Console.Read();
        }
    }
}
