using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    class Program
    {
       //static double Function1(int a, float b, double c)
       // {
       //     return a + b + c;
       // }
       // static void Function2(int a,float b,double c)
       // {
       //     Console.WriteLine(a + b + c);
       // }
       // static bool Function3(string str)
       // {
       //     if (str.Length > 5)
       //         return true;
       //     else
       //         return false;
       // }
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };
           Console.WriteLine( obj1.Invoke(10, 20f, 30));

            Action<int, float, double> obj2 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            obj2.Invoke(10, 20f, 40);

            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 5)
                    return true;
                else
                    return false;
            };
            Console.WriteLine( obj3.Invoke("bablua"));
            Console.Read();

        }
    }
}
