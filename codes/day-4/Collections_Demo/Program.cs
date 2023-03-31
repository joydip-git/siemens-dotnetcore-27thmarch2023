using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections_Demo
{
    internal class Program
    {
        static void SortListManually()
        {
            Person first = new Person { Id = 3, Name = "anil" };
            Person second = new Person { Id = 1, Name = "joydip" };
            Person third = new Person { Id = 2, Name = "sunil" };
            List<Person> peopleList = new List<Person>
            { first, second, third };

            //overload the > and < operator in the Person class for the following sorting
            for (int i = 0; i < peopleList.Count; i++)
            {
                for (int j = i + 1; j < peopleList.Count; j++)
                {
                    if (peopleList[i] > peopleList[j])
                    {
                        Person temp = peopleList[i];
                        peopleList[i] = peopleList[j];
                        peopleList[j] = temp;
                    }
                }
            }

            //Implement the CompareTo() method form IComparable/IComparable<T> in the Person class for the following sorting
            for (int i = 0; i < peopleList.Count; i++)
            {
                for (int j = i + 1; j < peopleList.Count; j++)
                {
                    if (peopleList[i].CompareTo(peopleList[j]) > 0)
                    {
                        Person temp = peopleList[i];
                        peopleList[i] = peopleList[j];
                        peopleList[j] = temp;
                    }
                }
            }
        }
        static void ListDemo()
        {
            //List of built-in value types
            List<int> list = new List<int>();
            //list.Add('a'); <= character is allowed since the ASCII value is added in the list whic is Integer
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

            Person first = new Person { Id = 3, Name = "anil" };
            Person second = new Person { Id = 1, Name = "joydip" };
            Person third = new Person { Id = 2, Name = "sunil" };

            //common technique of adding elements in the List<T>
            //List<Person> peopleList = new List<Person>();
            //peopleList.Add(first);

            //array initializer
            //Person[] list = new Person[] { first, second, third };

            //Collection initializer (3.0 -2007)
            List<Person> peopleList = new List<Person>
            { first, second, third };

            //A. Internalization of sorting
            //default sorting: ascending order
            //peopleList.Sort();
            //peopleList[0].CompareTo(peopleList[1])> 0
            //peopleList[0].CompareTo(peopleList[2])> 0
            //peopleList[1].CompareTo(peopleList[2])> 0

            //B. Externalization of sorting
            Console.WriteLine("Sort choice\n1. By Id \n2. By Name");
            Console.Write("Enter Choice[1/2]: ");
            int choice = int.Parse(Console.ReadLine());
            PersonComparsion pc = new PersonComparsion(choice);
            //You should pass object of such a class which implements IComparer<T> interface (i.e., implements int Compare(T x, T y))
            peopleList.Sort(pc);
            //pc.Compare(peopleList[0],peopleList[1])> 0
            //pc.Compare(peopleList[0],peopleList[2])> 0
            //pc.Compare(peopleList[1],peopleList[2])> 0

            foreach (Person p in peopleList)
            {
                Console.WriteLine(p);
            }
        }

        static void EqualityDemo()
        {
            //Object initializer (3.0 -2007)
            Person first = new Person { Id = 3, Name = "anil" };
            Person second = new Person { Id = 1, Name = "joydip" };
            Person third = new Person { Id = 2, Name = "sunil" };

            //oevrload the == and != operators in the Person class or he following equality checking
            if (third == first)
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("not same");
            }
            //override the Equals method from Objec class in he Peson class for the following equality checkin
            if (third.Equals(first))
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("not same");
            }
        }
        static void SetDemo()
        {
            //Set of built-in value types
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(1);
            foreach (int item in set)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            //Set of user deffined types

            //Object initializer (3.0 -2007)
            Person first = new Person { Id = 3, Name = "anil" };
            Person second = new Person { Id = 1, Name = "joydip" };
            Person third = new Person { Id = 2, Name = "sunil" };

            HashSet<Person> people = new HashSet<Person>();

            //set uses GetHashCode and Equals method of Object class for equality between the instances, hence it is must for a developer to override those methods in the user-defined (Person) type

            people.Add(first); //first.GetHashCode() [reference/Id]
            people.Add(second);//second.GetHashCode() [reference/Id]
            people.Add(third); //third.GetHashCode() [reference/Id] and third.Equals(first)

            foreach (Person item in people)
            {
                //Console.WriteLine(item.ToString());
                Console.WriteLine(item);
            }
        }

        static void DictionaryDemo()
        {
            //KeyValuePair<int, string> kv = new KeyValuePair<int, string>(1,"siemens");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(kv);

            dictionary.Add(1, "siemens");
            dictionary.Add(0, "healthineers");
            dictionary.Add(2, "bangalore");

            //exception will be thrown if the key already exists
            //dictionary.Add(2, "ECity");

            //value will be updated if the key already exists (will not throw any exception)
            dictionary[2] = "ECity";

            //value will be updated if the key already exists (will not throw any exception) and key+value will be added if the key does not exist
            dictionary[100] = "Bangalore";

            dictionary.Remove(100);

            if (dictionary.ContainsKey(100))
            {
                Console.WriteLine(dictionary[100]);
            }
            else
            {
                Console.WriteLine("key not found");
            }

            if (dictionary.ContainsValue("healthineers"))
            {
                Console.WriteLine("value exists");
            }
            else
                Console.WriteLine("value does not exist");


            foreach (KeyValuePair<int, string> kv in dictionary)
            {
                Console.WriteLine($"{kv.Key}:{kv.Value}");
            }
        }
        static void SortedListDemo()
        {
            //KeyValuePair<int, string> kv = new KeyValuePair<int, string>(1,"siemens");

            SortedList<int, string> sortedList = new SortedList<int, string>();
            //sortedList.Add(kv);
            sortedList.Add(1, "siemens");
            sortedList.Add(0, "healthineers");
            sortedList.Add(2, "bangalore");

            //exception will be thrown if the key already exists
            //sortedList.Add(2, "ECity");

            //value will be updated if the key already exists (will not throw any exception)
            sortedList[2] = "ECity";

            //value will be updated if the key already exists (will not throw any exception) and key+value will be added if the key does not exist
            sortedList[100] = "Bangalore";

            sortedList.Remove(100);

            if (sortedList.ContainsKey(100))
            {
                Console.WriteLine(sortedList[100]);
            }
            else
            {
                Console.WriteLine("key not found");
            }

            if (sortedList.ContainsValue("healthineers"))
            {
                Console.WriteLine("value exists");
            }
            else
                Console.WriteLine("value does not exist");

            foreach (KeyValuePair<int, string> kv in sortedList)
            {
                Console.WriteLine($"{kv.Key}:{kv.Value}");
            }
        }
        static void Main()
        {
            DictionaryDemo();
            Console.WriteLine("\n");
            SortedListDemo();
        }
    }
}
