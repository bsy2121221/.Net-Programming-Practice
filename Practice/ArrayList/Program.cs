using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main()
        {
            //you can give also initial capacity in constructor
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            //adding the items
            al.Add(100);
            al.Add(200);
            al.Add(300);
            al.Add(400);

            //adding item in middle
            al.Insert(3, 350);
            foreach(object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            //remove item
           // al.Remove(200);
            //remove from index
            al.RemoveAt(1);
            foreach (object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.ReadLine();


        }
    }
}
