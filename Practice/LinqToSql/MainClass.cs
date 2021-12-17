using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    class MainClass
    {
        static void Main()
        {
            GraskoDataContext dc = new GraskoDataContext();
            var EmpQuery = from emp in dc.Employees
                           where emp.Salary == 20300
                           select emp;
            foreach(var e in EmpQuery)
            {
                Console.WriteLine("ID={0}",e.Emp_ID);
                Console.WriteLine("EmpName={0}",e.Emp_Name);
                Console.WriteLine("Emp Salary={0}",e.Salary);
                Console.WriteLine("Dep Id={0}",e.DID);
                Console.WriteLine("---------------------------------------");
            }
            Employee emp1 = new Employee();
            emp1.Emp_Name = "Sonu";
            emp1.Salary = 20300;
            emp1.DID = 2;
            dc.Employees.InsertOnSubmit(emp1);
           // dc.SubmitChanges();
            Console.Read();

        }
    }
}
