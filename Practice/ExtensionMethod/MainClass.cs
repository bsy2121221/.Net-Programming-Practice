using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class MainClass
    {
       
        static void Main()
        {
            ParentClass obj = new ParentClass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            int i=10;
            Console.WriteLine(i.Factorial());
            Console.ReadLine();
        }
    }
}
