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
        private static Singleton Instance = null;
        public static readonly object obj = new object();
        public static Singleton GetIansatance
        {
            get
            {

        //lock take more time
        //so we can avoid lock checking every time 
        //And this is the process to check two time checking is called     double check locking
                if (Instance == null)
                {
                    lock (obj)
                    {
                        if (Instance == null)
                        Instance = new Singleton();
                    }
                }
                return Instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value is" + counter);
        }
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
