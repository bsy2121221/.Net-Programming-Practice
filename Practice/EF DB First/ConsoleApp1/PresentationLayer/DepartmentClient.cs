
namespace ConsoleApp1
{
    class DepartmentClient
    {
        public static void AddDepartments()
        {
            Department d1 = new Department(); d1.DID = 101; d1.DName = "HR";
            Department d2 = new Department(); d2.DID = 102; d2.DName = "Admin";
            Department d3 = new Department(); d3.DID = 103; d3.DName = "Software";

            DAL.Departments.Add(d1);
            DAL.Departments.Add(d2);
            DAL.Departments.Add(d3);
        }
    }
}
