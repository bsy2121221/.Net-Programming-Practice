using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In celecious the temp is:" + StaticClass.ToCelcious(98.6));
            Console.WriteLine("In ferenhite the temp is:" + StaticClass.ToFerenhite(37));
            Console.ReadLine();
        }
    }
}
