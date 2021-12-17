using System;
using System.Linq;

namespace ConsoleApp1
{
    class Report
    {
        public static void GenerateReport()
        {
            foreach (Employee emp in DAL.Employees)
            {
                Console.WriteLine("Emp: {0}\tDept: {1}", emp.EmpName, emp.EmpDepartment.DName);
            }

            Console.WriteLine("--------------------------------------------------------");

            var query = from emp in DAL.Employees
                        where emp.EmpDepartment.DName == "HR"
                        select emp;

            foreach (Employee emp in query)
            {
                Console.WriteLine("Emp: {0}\tDept: {1}", emp.EmpName, emp.EmpDepartment.DName);
            }
        }
    }
}
