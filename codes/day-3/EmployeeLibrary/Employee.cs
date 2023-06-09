﻿using System;
using System.Data;

namespace EmployeeLibrary
{
    public class Employee
    {
        string name;
        string projectName;
        DateTime? dob;
        int age;
        readonly int id;
        static decimal joiningbonus;// = 1000;
        static readonly string department;// = "Syngo";
        public const string COMPANY_NAME = "Siemens";

        //public decimal Salary { get; set; } = 10000;

        static Employee()
        {
            Console.WriteLine("static ctor executed");
            joiningbonus = 1000;
            department = "DX";
        }

        public Employee() { }

        //optional argument with default value (4.0 -2010)
        public Employee(string name, int id, decimal bonus = 1000, DateTime? dob = null, string projectName = null)
        {
            Console.WriteLine("instance ctor executed");
            joiningbonus = bonus;
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.projectName = projectName;
        }
        //public void SetProjectName(string project)
        //{
        //    this.projectName = project;
        //}
        //public string GetProjectName()
        //{
        //    return this.projectName;
        //}
        //public string GetName()
        //{
        //    return this.name;
        //}

        public int Id => id;
        //property Function (read-only - getter, write-only - setter)
        public string ProjetName
        {
            //public void SetProjectName(string project)
            set
            {
                this.projectName = value;
            }
            //public string GetProjectName()
            get
            {
                return this.projectName;
            }
        }

        public string Name
        {
            set => this.name = value;
            get => this.name;
        }

        public DateTime? Dob
        {
            set
            {
                if (value.HasValue)
                {
                    this.dob = value;
                    TimeSpan difference = DateTime.Now.Subtract(value.Value);
                    //this.Age = difference.Days / 365;
                    this.age = difference.Days / 365;
                }
            }
        }

        //public int Age
        //{
        //    private set => this.age = value;
        //    get => this.age;
        //}

        public int Age => this.age;

        //public int GetAge() { return this.age; }
        //public int GetAge() => this.age;

        //Indexer (property)
        public object this[string propName]
        {
            set
            {
                if (propName != "name" && propName != "project" && propName != "dob")
                    throw new ArgumentException("Incorrect index");


                switch (propName)
                {
                    case "name":
                        this.name = (string)value;
                        break;

                    case "project":
                        this.projectName = (string)value;
                        break;

                    case "dob":
                        this.dob = (DateTime?)value;
                        break;

                    default:
                        break;
                }
            }
            get
            {
                if (propName == "id")
                {
                    return this.id;
                }
                if (propName == "name")
                {
                    return this.name;
                }
                if (propName == "project")
                {
                    return this.projectName;
                }
                if (propName == "dob")
                {
                    return this.dob;
                }
                throw new ArgumentException("Incorrect indexer");
            }
        }

        public object this[int propIndex]
        {
            set
            {
                if (propIndex < 0 && propIndex > 2)
                    throw new ArgumentException("Incorrect index");

                switch (propIndex)
                {
                    case 0:
                        this.name = (string)value;
                        break;

                    case 1:
                        this.projectName = (string)value;
                        break;

                    case 2:
                        this.dob = (DateTime?)value;
                        break;

                    default:
                        break;
                }
            }
            get
            {
                if (propIndex == 0)
                {
                    return this.id;
                }
                if (propIndex == 1)
                {
                    return this.name;
                }
                if (propIndex == 2)
                {
                    return this.projectName;
                }
                if (propIndex == 3)
                {
                    return this.dob;
                }
                return "Incorrect Index: Indxex should be between 0 and 2 ";
            }
        }
    }
}
