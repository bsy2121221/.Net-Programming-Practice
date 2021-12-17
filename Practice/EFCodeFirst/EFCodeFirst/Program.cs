using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFCodeFirst
{
    class Program
    {
        static void Main()
        {
            //using (var db = new BloggingContext())
            //{
            //    // Create and save a new Blog
            //    Console.Write("Please enter blog name: ");
            //    string blogName = Console.ReadLine();

            //    Blog blog = new Blog();
            //    blog.Name = blogName;
            //    db.Blogs.Add(blog);
            //    db.SaveChanges();

            //    // List all available blogs in the DB
            //    Console.WriteLine("All blogs in the DB:");
            //    foreach (var item in db.Blogs.ToList())
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //    Console.ReadLine();
            //}

            using (var cust = new CustomerContext())
            {
                cust.Customers.Add(new Customer { Name = "Rajeev", City = "Mumbai" });
                cust.Customers.Add(new Customer { Name = "Sanjeev", City = "Chennai" });
                cust.Customers.Add(new Customer { Name = "Rajan", City = "Mumbai" });
                cust.Customers.Add(new Customer { Name = "Sajan", City = "Bangalore" });
                cust.Customers.Add(new Customer { Name = "Madhav", City = "Delhi" });
                cust.Customers.Add(new Customer { Name = "Sadhu", City = "Mumbai" });
                cust.Customers.Add(new Customer { Name = "Madhu", City = "Hyderabad" });
                cust.Customers.Add(new Customer { Name = "Raghav", City = "Mumbai" });
                cust.Customers.Add(new Customer { Name = "Sandu", City = "Bangalore" });
                
                cust.SaveChanges();

                var customerQuery = from c in cust.Customers.ToList()
                                    where c.City == "Mumbai"
                                    select c;

                foreach (var customer in customerQuery)
                {
                    Console.Write(customer.Name + "\t");
                    Console.WriteLine(customer.City);
                }

            }
            Console.WriteLine("---------------------------");


        }
    }
}
