using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    class MainClass
    {
        public enum days
        {
            Monday=2,
            Tuesday,
            Wednesday,
            Thuresday,
            Friday,
            Saturday,
            Sunday
        }
        public static days MeetingDate
        {
            get;
            set;
        } = days.Saturday;
        static void Main()
        {
            days d =(days)2;
            days d1 = days.Monday;
            Console.WriteLine(d);
            Console.WriteLine(d1);

            foreach(int i in Enum.GetValues(typeof(days))){
                Console.WriteLine(i+"="+(days)i);
            }

            Console.WriteLine(MeetingDate);
        
            Console.ReadLine();
        }
    }
}
