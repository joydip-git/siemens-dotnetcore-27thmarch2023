using System;
using OutstandingPersonApp.DataAccessLayer;
using OutstandingPersonApp.Entities;
using static OutstandingPersonApp.UserInterface.Utility.UiUtility;

namespace OutstandingPersonApp.UserInterface
{
    internal class Program
    {
        static void Main()
        {
            PersonManager manager = new();
            for (int index = 0; index < 4; index++)
            {
                PrintMenu();
                int choice = GetChoice();
                Person person = CreatePerson(choice);
                bool status = manager.AddPerson(person);
                Console.WriteLine(status ? "Person Added" : "Could not add");
            }

            Person[] all = manager.GetPeople();
            foreach (Person personObj in all)
            {
                if (personObj != null)
                {
                    if (personObj.IsOutstanding())
                    {
                        if (personObj is Professor)
                        {
                            Professor professor = (Professor)personObj;
                            Console.WriteLine(professor.Print());
                        }
                        if (personObj is Student)
                        {
                            Student student = personObj as Student;
                            Console.WriteLine(student.Show());
                        }
                    }
                }
            }
        }
    }
}
