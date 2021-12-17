using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemoWithThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintEmployeeDetails(),
                () => PrintStudentDetails()
                );
            Console.Read();
        }
        private static void PrintEmployeeDetails()
        {
            Singleton EmployeeObj = Singleton.GetIansatance;
            EmployeeObj.DisplayMessage("Employee Execution");
        }
        private static void PrintStudentDetails()
        {
            Singleton StudentObj = Singleton.GetIansatance;
            StudentObj.DisplayMessage("Student Execution");
        }
    }
}
