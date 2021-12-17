using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IENumerableAndIenumerator
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(400);
            list.Add(500);
            list.Add(600);
            list.Add(700);


           // IEnumerable<int> ienum = list;
            IEnumerator<int> ienum =list.GetEnumerator();
            Range100to400(ienum);

            Console.ReadKey();

        }

        public static void Range100to400(IEnumerator<int> ienum)
        {

            //foreach (var enu in ienum)
            //{
            //    Console.WriteLine(enu);
            //    if (enu > 400)
            //        RangeAbove500(ienum);
            //}

            while (ienum.MoveNext())
            {
                Console.WriteLine(ienum.Current.ToString());
                if (ienum.Current >= 400)
                    RangeAbove500(ienum);
            }
        }
        public static void RangeAbove500(IEnumerator<int> o)
        {
            //foreach(var en in o)
            //{
            //    Console.WriteLine(en);
            //}
            Console.WriteLine("After 400");
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current.ToString());
            }
        }
    }
}
