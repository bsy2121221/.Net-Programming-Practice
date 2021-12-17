using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemoWithThread
{
    class Singleton
    {
        private static int counter = 0;
        //Eager loading means pre instantiation of object
        private static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(()=>new Singleton());

        public static Singleton GetIansatance
        {
            get
            {
                return Instance.Value;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Instance number is " + counter);
        }
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

