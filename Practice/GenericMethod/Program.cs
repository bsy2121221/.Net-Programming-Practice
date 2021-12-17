using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class Program
    {
       public bool Compare<T>(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            if (d1==d2)
                return true;
            return false;
        }
        static void Main()
        {
            Program obj = new Program();
            bool result=obj.Compare<float>(1.22f, 2.33f);
            Console.WriteLine(result);

            Console.WriteLine(obj.Compare<int>(10, 10));
            Console.WriteLine(obj.Compare<bool>(false, false));
            Console.ReadLine();

        }
    }
}
