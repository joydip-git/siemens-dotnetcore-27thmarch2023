using PayrollApp.Entities;
using System;

namespace PayrollApp.UserInterface.Utility
{
    public static class UiUtility
    {
        #region Public Methods
        public static int EnterNumberOfRecords()
        {
            Console.Write("How many records?: ");
            return int.Parse(Console.ReadLine());
        }
        public static void SaveEmployees(Employee[] employees)
        {
            for (int index = 0; index < employees.Length; index++)
            {
                PrintEmployeeMenu();
                int choice = EnterEmployeeChoice();
                Employee employee = CreateEmployee(choice);
                employee.CalculateSalary();
                if (employee != null)
                {
                    employees[index] = employee;
                }
            }
        }
        public static void PrintEmployees(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine($"{employee.Name} with Id:{employee.Id} got salary of {employee.TotalSalary}");
                }
            }
        }
        #endregion

        #region Helper Methods
        private static void PrintEmployeeMenu()
        {
            Console.WriteLine("1. Developer\n2. HR ");
        }
        private static int EnterEmployeeChoice()
        {
            Console.Write("\nEnter choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
        private static Employee CreateEmployee(int choice)
        {
            Employee employee = null;

            Console.Write("\nEnter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Basic: ");
            decimal basic = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Da: ");
            decimal da = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Hra: ");
            decimal hra = decimal.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Incentive: ");
                    decimal incentive = decimal.Parse(Console.ReadLine());
                    employee = new Developer(name, basic, da, hra, incentive);
                    break;

                case 2:
                    Console.Write("Enter Gratuity: ");
                    decimal gratuity = decimal.Parse(Console.ReadLine());
                    employee = new HumanResource(name, basic, da, hra, gratuity);
                    break;

                default:
                    break;
            }

            return employee;
        }
        #endregion
    }
}
