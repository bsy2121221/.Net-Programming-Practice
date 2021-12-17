using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icomparable
{
    //If you want to sort user defined data based on some condition than you need to use IComparable interface

    public class Student : IComparable<Student>
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public double Marks { get; set; }

        public int CompareTo(Student other)
        {
            if (this.RollNo > other.RollNo)
                return 1;
            else if (this.RollNo < other.RollNo)
                return -1;
            else
                return 0;
        }
    }
    //And if IComparable is predefined in previous and you want to sort based on
    //another type than you need to implements ICompraer interface
    public class Student2 : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;

        }
    }
    class MainClass
    {
        static void Main()
        {
           
            Student s1 = new Student { RollNo = 1, Name = "A", Class = 2, Marks = 67.7 };
            Student s2 = new Student { RollNo = 2, Name = "B", Class = 2, Marks = 67.7 };
            Student s3 = new Student { RollNo = 3, Name = "C", Class = 2, Marks = 64.7 };
            Student s4 = new Student { RollNo = 4, Name = "D", Class = 2, Marks = 65.7 };
            Student s5 = new Student { RollNo = 5, Name = "E", Class = 2, Marks = 65.7 };
            List<Student> students = new List<Student> { s1, s2, s3, s4, s5 };
            students.Sort();

            foreach(var stu in students)
            {
                Console.WriteLine(stu.RollNo + " " + stu.Name + " " + stu.Class + " " + stu.Marks);
            }

            Student2 obj = new Student2();
            students.Sort(obj);
            Console.WriteLine("Sorting based on Marks:-----");
            foreach (var stu in students)
            {
                Console.WriteLine(stu.RollNo + " " + stu.Name + " " + stu.Class + " " + stu.Marks);
            }
            Console.ReadLine();
        }
    }
}
