using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine(z);
            }
            catch(DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            finally
            {
                Console.WriteLine("this statement in finally");
            }
            Console.WriteLine("End of the program");
            
           

        }
    }
}
