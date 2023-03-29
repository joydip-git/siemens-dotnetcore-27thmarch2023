using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Person
    {
        string name;
        public Person()
        {

        }
        public Person(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Name == p2.Name;
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1.Name == p2.Name);
        }
    }
}
