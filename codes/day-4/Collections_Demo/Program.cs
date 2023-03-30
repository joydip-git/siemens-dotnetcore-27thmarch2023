using System;
using System.Collections.Generic;

namespace Collections_Demo
{
    class Person //Object
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Name}, {Id}";
        }
        //Object class's original GetHasCode (Virtual) clculates hash code based on reference
        //You need to override that GetHashCode
        public override int GetHashCode()
        {
            int hash = this.Id.GetHashCode();
            return hash;
        }
        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            if (this == person)
            {
                return true;
            }

            if (this.Id != person.Id)
            {
                return false;
            }
            else
                return true;
        }
    }
    internal class Program
    {
        static void Main()
        {
            /*
            List<int> list = new List<int>();
            list.Add(1); //0
            list.Add(2); //1
            list.Add(3); //2
            list.Add(4);
            list.Add(6);
            list.Add(7);
            list.Add(3);
            list.Add(8);
            list.Add(9); //8
            list.Insert(1, 11); //index <= count
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.WriteLine("\n");
            //list.Remove(11);
            //list.RemoveAt(1);
            list.Sort();
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            //list.Add('a');
            Console.WriteLine("\n");
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(1);
            foreach (int item in set)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            */
            HashSet<Person> people = new HashSet<Person>();
            //Object initializer (3.0 -2007)
            Person first = new Person { Id = 1, Name = "anil" };
            Person second = new Person { Id = 2, Name = "sunil" };
            Person third = new Person { Id = 1, Name = "anil" };

            people.Add(first); //first.GetHashCode() => first.Equals(other)
            people.Add(second);
            people.Add(third);

            foreach (Person item in people)
            {
                //Console.WriteLine(item.ToString());
                Console.WriteLine(item);
            }
        }
    }
}
