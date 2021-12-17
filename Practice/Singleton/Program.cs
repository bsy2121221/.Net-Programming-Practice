using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj1 = Singleton.GetInsatnce;
            obj1.DisplayMessage("from first object");
            Singleton obj2 = Singleton.GetInsatnce;
            obj2.DisplayMessage("From second object");
            Console.Read();
        }
    }
}
