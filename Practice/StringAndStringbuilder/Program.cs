using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for(int i = 0; i < 100000; i++)
            {
                str += i;
            }
            sw1.Stop();
            StringBuilder sb = new StringBuilder();
            sb.Append("hello");
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for(int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();

            Console.WriteLine("String time" + sw1.ElapsedMilliseconds);
            Console.WriteLine("stringbuilder time" + sw2.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
