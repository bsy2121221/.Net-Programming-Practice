using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class ThreadLocking
    {
        void Test1()
        {
            lock (this)
            {
                Console.Write("[Csharp is an ");
                Thread.Sleep(4000);
                Console.WriteLine("object oriented language");
            }
           
        }
        public static void Main()
        {
            ThreadLocking obj = new ThreadLocking();
            Thread t1 = new Thread(obj.Test1);
            Thread t2 = new Thread(obj.Test1);
            Thread t3 = new Thread(obj.Test1);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.Read();
        }

    }
}
