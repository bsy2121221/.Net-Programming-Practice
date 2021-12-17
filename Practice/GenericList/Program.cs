using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Customer
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public double Salary { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Customer> Customers = new List<Customer>();
            Customer c1 = new Customer()
            {
                ID = 1001,
                Name = "a",
                Salary = 59000.00
            };
            Customer c2 = new Customer()
            {
                ID = 1002,
                Name = "b",
                Salary = 54000.00
            };
            Customer c3 = new Customer()
            {
                ID = 1003,
                Name = "C",
                Salary = 53000.00
            };
            Customers.Add(c1); Customers.Add(c2); Customers.Add(c3);

            foreach(var obj in Customers)
            {
                Console.WriteLine("ID= "+obj.ID + " Name= " + obj.Name + " salary= " + obj.Salary);
            }

            Console.ReadLine();

        }
    }
}
