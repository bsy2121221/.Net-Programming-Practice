using System;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Emid", 1001);
            ht.Add("EName", "Rogers");
            ht.Add("job", "Avenger");
            ht.Add("Email", "Rogers@mail.com");

            //print only key
            foreach(var key in ht.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("----------------------");
            //print only value
            foreach(var val in ht.Values)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("Key and value");

            foreach(var key in ht.Keys)
            {
                Console.WriteLine(key + ":" + ht[key]);
            }
            Console.ReadLine();
            
        }
    }
}
