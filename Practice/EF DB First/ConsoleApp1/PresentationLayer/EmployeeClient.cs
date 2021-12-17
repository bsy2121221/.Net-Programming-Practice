
namespace ConsoleApp1
{
    class EmployeeClient
    {
        public static void AddEmployees()
        {
            Employee e1 = new Employee() { EmpId = 1, EmpName = "Dhiraj", Salary = 12000, EmpDepartment = DAL.Departments[0], Dept_ID = DAL.Departments[0].DID};
            Employee e2 = new Employee(); e2.EmpId = 2; e2.EmpName = "Niraj"; e2.Salary = 13000; e2.EmpDepartment = DAL.Departments[1]; e2.Dept_ID = e2.EmpDepartment.DID;
            Employee e3 = new Employee(); e3.EmpId = 3; e3.EmpName = "Suraj"; e3.Salary = 12500; e3.EmpDepartment = DAL.Departments[0]; e3.Dept_ID = e3.EmpDepartment.DID;
            Employee e4 = new Employee(); e4.EmpId = 4; e4.EmpName = "Biraj"; e4.Salary = 14000; e4.EmpDepartment = DAL.Departments[1]; e4.Dept_ID = e4.EmpDepartment.DID;
            Employee e5 = new Employee(); e5.EmpId = 5; e5.EmpName = "Rajesh"; e5.Salary = 11800; e5.EmpDepartment = DAL.Departments[2]; e5.Dept_ID = e5.EmpDepartment.DID;
            Employee e6 = new Employee(); e6.EmpId = 6; e6.EmpName = "Dhiraj"; e6.Salary = 15000; e6.EmpDepartment = DAL.Departments[1]; e6.Dept_ID = e6.EmpDepartment.DID;
            Employee e7 = new Employee(); e7.EmpId = 1; e7.EmpName = "Dhiraj"; e7.Salary = 12000; e7.EmpDepartment = DAL.Departments[2]; e7.Dept_ID = e7.EmpDepartment.DID;

            DAL.Employees.Add(e1);
            DAL.Employees.Add(e2);
            DAL.Employees.Add(e3);
            DAL.Employees.Add(e4);
            DAL.Employees.Add(e5);
            DAL.Employees.Add(e6);
            DAL.Employees.Add(e7);
        }
    }
}
