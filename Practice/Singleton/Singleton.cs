using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static int count=0;
        private static Singleton Insatance = null;
        public static Singleton GetInsatnce
        {
            get
            {
                if (Insatance == null)
                    Insatance = new Singleton();
                return Insatance;
            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine("Instance call " + count);
        }
        public void DisplayMessage( string message)
        {
            Console.WriteLine(message);
        }
    }
}
