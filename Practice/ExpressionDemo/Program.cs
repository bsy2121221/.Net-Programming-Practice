using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ExpressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<Student, bool>> isTeenegerExr = s => s.Age > 12 && s.Age < 20;
            Func<Student, bool> isTeenager = isTeenegerExr.Compile(); //convertiong expression type to delegate type

            bool result = isTeenager(new Student() { StudentID = 12, StudentName = "Rahul", Age = 19 });
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
