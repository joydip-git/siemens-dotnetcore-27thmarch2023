using System;

namespace Collections_Demo
{
    class Person : IComparable<Person> //Object
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

        public int CompareTo(Person other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Id.Equals(p2.Id);
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1.Id.Equals(p2.Id));
        }
        public static bool operator <(Person p1, Person p2)
        {
            return p1.Id < p2.Id;
        }
        public static bool operator >(Person p1, Person p2)
        {
            return p1.Id > p2.Id;
        }
    }
}
