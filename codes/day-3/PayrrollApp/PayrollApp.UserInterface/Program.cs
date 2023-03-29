using PayrollApp.Entities;
using System;
using static PayrollApp.UserInterface.Utility.UiUtility;

namespace PayrollApp.UserInterface
{
    internal class Program
    {
        static void Main()
        {
            int records = EnterNumberOfRecords();
            Employee[] employees = new Employee[records];
            SaveEmployees(employees);
            PrintEmployees(employees);
        }
        
    }
}
