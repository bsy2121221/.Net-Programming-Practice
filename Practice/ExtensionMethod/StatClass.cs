using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
   static class StatClass
    {
        public static void Method3(this ParentClass p)
        {
            Console.WriteLine("Method3");
        }
        public static long Factorial(this Int32 x)
        {
            if (x == 1)
                return 1;
            else if (x == 2)
                return 2;
            return x * Factorial(x-1);
        }
    }
}
