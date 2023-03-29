using System;
using EmployeeLibrary;

namespace OOP_CSharp
{
    class A
    {
        //protected string name;
        private string name;

        public A()
        {
            Console.WriteLine("A default ctor");
        }

        public A(string name)
        {
            Console.WriteLine("A parameterized ctor");
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
    }
    class B : A
    {
        int id;

        public B()
        {
            Console.WriteLine("B default ctor");
        }

        public B(string name, int id) : base(name)
        {
            Console.WriteLine("B parameterized ctor");
            //this.name = name;
            this.id = id;
            //base.Name
        }

        public int Id { get => id; set => id = value; }
    }

    internal class Program
    {
        static void Main()
        {
            B b = new B("anil", 1);
            //Employee employee = new Employee("joydip", 1);
            //Employee employee2 = new Employee("anil", 2);
            //employee.SetProjectName("CITA");
            //Console.WriteLine(employee.GetProjectName());
            //employee.Dob = new DateTime(2000, 3, 29);      
            //employee.ProjetName = "CITA";
            //Console.WriteLine(employee.ProjetName);
            //Console.WriteLine(employee.Age);
            //arr[] 
            //employee["name"] = "Joydip";
            //employee["project"] = "CITA";
            //employee["dob"] = new DateTime(2000, 3, 29);

            //Console.WriteLine(employee[0]);
            //Console.WriteLine(employee[1]);
            //Console.WriteLine(employee[2]);
            //Console.WriteLine(employee[3]);

            Console.WriteLine(EmployeeInfo.Joiningbonus);
            Console.WriteLine(Employee.COMPANY_NAME);

            //int[] arr = new int[] { 1, 2, 3 };
            //arr[0] = 10;
        }
    }
}
