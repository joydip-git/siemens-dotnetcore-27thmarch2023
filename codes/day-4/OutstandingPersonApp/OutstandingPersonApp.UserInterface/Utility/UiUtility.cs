using OutstandingPersonApp.Entities;
using System;

namespace OutstandingPersonApp.UserInterface.Utility
{
    internal static class UiUtility
    {
        public static void PrintMenu()
        {
            Console.WriteLine("1. Professor\n2. Student");
        }
        public static int GetChoice()
        {
            Console.Write("\nEnter Choice[1/2]:  ");
            return int.Parse(Console.ReadLine());
        }
        public static Person CreatePerson(int choice)
        {
            Person person = null;

            Console.Write("\nName: ");
            string name = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Books Published: ");
                    int books = int.Parse(Console.ReadLine());
                    person = new Professor(name, books);
                    break;

                case 2:
                    Console.Write("Marks: ");
                    int marks = int.Parse(Console.ReadLine());
                    person = new Student(name, marks);
                    break;

                default:
                    break;
            }
            return person;
        }
    }
}
