
namespace ConsoleApp1
{
    class Employee
    {
        public byte EmpId { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public byte Dept_ID { get; set; }
        public Department EmpDepartment { get; set; }

        //public Employee(byte id,string name,int salary,Department d)
        //{
        //    this.EmpId = id;
        //    this.EmpName = name;
        //    this.Salary = salary;
        //    this.EmpDepartment = d;
        //    this.Dept_ID = EmpDepartment.DID;
        //}
    }
}
