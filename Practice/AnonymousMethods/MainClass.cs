using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    class MainClass
    {
        public delegate string GreetingDelegate(string name);
        //static string Greeting(string name)
        //{
        //    return "Hello " + name;
        //}
        static void Main()
        {
            //Anonymous Method
            //used when lesser method body
            GreetingDelegate obj = delegate (string name)
            {
                return "hello " + name;
            };

            //By using of lambda expression
            GreetingDelegate d = (name) =>
              {
                  return "Hello " + name;
              };
            Console.WriteLine(obj.Invoke("scott"));
            Console.WriteLine(d("Bablu"));
            Console.ReadLine();
        }
    }
}
