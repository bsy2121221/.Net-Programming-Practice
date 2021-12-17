using System;
using System.Reflection;

namespace ReflectionDemo
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("ReflectionDemo.student");
            Console.WriteLine("Name={0}", T.Name);
            Console.WriteLine("Just the namespace={0}", T.Namespace);
            Console.WriteLine("Full name" + T.FullName);

            PropertyInfo[] properties=T.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name+"    "+property.PropertyType);
            }
            Console.ReadLine();

        }
    }
    class student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public student(int id,string name)
        {
            this.StudentID = id;
            this.StudentName = name;
        }
        public student()
        {
            this.StudentID = -1;
            this.StudentName = string.Empty;
        }

        public void PrintID()
        {
            Console.WriteLine("ID={0}", this.StudentID);
        }
        public void PrintName()
        {
            Console.WriteLine("Name={0}", this.StudentName);
        }

    }
}
