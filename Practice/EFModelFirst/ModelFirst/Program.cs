using System;

namespace ModelFirst
{
    class Program
    {
        static void Main()
        {
            MyDAL MyData = new MyDAL();
            Person p = new Person();
            p.ID = 101;
            p.Name = "Suraj";
            p.City = "Bangalore";
            p.Country = "India";
            MyData.Persons.Add(p);
            MyData.SaveChanges();
            Console.WriteLine("------------");
        }
    }
}
