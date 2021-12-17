using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api1.Model
{
    public class EmployeeIndexer
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;
        public EmployeeIndexer(int Eno,double Salary,string Ename,string Job,string Dname,string Location)
        {
            this.Eno = Eno;
            this.Salary = Salary;
            this.Ename = Ename;
            this.Job = Job;
            this.Dname = Dname;
            this.Location = Location;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Eno;
                else if (index == 1)
                    return Salary;
                else if (index == 2)
                    return Ename;
                else if (index == 3)
                    return Job;
                else if (index == 4)
                    return Dname;
                else if (index == 5)
                    return Location;
                return null;
            }
        }
    }
    
   
}
