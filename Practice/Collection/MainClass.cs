using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Employee
    {
    }
    class MainClass
    {
        static void UsingArrayList()
        {
            ArrayList al = new ArrayList(5);
            al.Add(12);
            al.Add("bss");
            al.Add(new object());
            al.Add("Mss");
            al.Add(23);
            al.Add(new MainClass());
            al.Add(new Queue());

            al.RemoveAt(3);
            al.Remove("Dh");
            al.RemoveAt(3);

            //al.RemoveAt(3);
            foreach (object o in al)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("\nCapacity: "+al.Capacity);
            Console.WriteLine("Count: "+al.Count);
        }
        static void UsingHashTable()
        {
            Hashtable h = new Hashtable();
            h.Add(1, "Dhiraj");
            h.Add(4, "Niraj");
            h.Add(7, "Biraj");
            h.Add(2, "Suraj");
            h.Add(5, "Ramesh");
            h.Add(3, "Suresh");
            h.Add(6, "Himesh");
            
            foreach (object o in h.Values)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("------------------------------");
            foreach (int i in h.Keys)
            {
                Console.WriteLine(h[i]);
            }
        }
        static void UsingSortedList()
        {
            SortedList sl = new SortedList();
            sl.Add("A1", "Dhiraj");
            sl.Add("A4", new Employee());
            sl.Add("A7", "10");
            sl.Add("A2", "Suraj");
            sl.Add("A5", "Ramesh");
            sl.Add("A3", "Suresh");
            sl.Add("A6", "Himesh");

            ICollection c = sl.Values;
            foreach(object o in sl.Values)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("---------------------------");
            foreach (string i in sl.Keys)
            {
                Console.WriteLine(sl[i]);
            }
            Console.WriteLine("\n{0} is at Index 1",sl.GetByIndex(1));
        }      
        public static void UsingGenericList()
        {
            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(5);
            intList.Add(30);
            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }

        }
        public static void UsingHashSet()
        {
            string[] arr1 = { "Table", "Chair", "Pen", "Clip", "Table" };
            HashSet<string> h = new HashSet<string>(arr1);//Hash set eliminates duplicate values
            foreach (string s in h)
            {
                Console.WriteLine(s);
            }
        }
        static void Main()
        {
            //UsingArrayList();
            //UsingSortedList();
            //UsingHashTable();
            //UsingGenericList();
            //UsingHashSet();           

        }        
    }
}
