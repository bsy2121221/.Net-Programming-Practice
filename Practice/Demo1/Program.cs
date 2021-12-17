using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main()
        {
            DateTime dt = new DateTime(1998, 3, 2, 4, 57, 50);
            Console.WriteLine(dt.ToString());
            Console.WriteLine(dt.Date.ToString("D"));
            Console.WriteLine(dt.Date.ToString("g"));
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Hour);
            Console.ReadLine();
        }
    }
}
