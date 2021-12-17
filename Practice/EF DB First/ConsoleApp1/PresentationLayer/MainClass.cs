using System;
using System.Linq;

namespace ConsoleApp1
{
    class MainClass
    {
        static void Main()
        {
            DepartmentClient.AddDepartments();
            EmployeeClient.AddEmployees();
            Report.GenerateReport();

        }
    }
}
