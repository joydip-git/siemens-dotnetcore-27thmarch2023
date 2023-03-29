using System;
using EmployeeLibrary;

namespace OOP_CSharp
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee("joydip");
            //employee.SetProjectName("CITA");
            //Console.WriteLine(employee.GetProjectName());
            //employee.Dob = new DateTime(2000, 3, 29);      
            //employee.ProjetName = "CITA";
            //Console.WriteLine(employee.ProjetName);
            //Console.WriteLine(employee.Age);
            //arr[] 
            employee["name"] = "Joydip";
            employee["project"] = "CITA";
            employee["dob"]= new DateTime(2000, 3, 29);

            Console.WriteLine(employee[0]);
            Console.WriteLine(employee[1]);
            Console.WriteLine(employee[2]);
            Console.WriteLine(employee[3]);


            //int[] arr = new int[] { 1, 2, 3 };
            //arr[0] = 10;
        }
    }
}
