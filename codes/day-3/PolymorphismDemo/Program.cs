using System;

namespace PolymorphismDemo
{
    class A
    {
        string name;
        public A()
        {

        }
        public A(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

        public virtual string Print() //called function
        {
            return name;
        }
    }
    class B : A
    {
        int id;
        public B()
        {

        }

        public B(string name, int id) : base(name)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }

        /*
         * 
        public string Print()
        {
            return name;
        }
         */
        public override string Print()
        {
            return $"Name:{Name}, Id:{id}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            //up-casting
            A obj = new B("anil", 1);
            Console.WriteLine(obj.Print());//function call

            /*
            Addition addition = new Addition();
            addition.Add(12, 13);//function call-1
            addition.Add(13, 14, 15);//functin call-2
            addition.Add(13, 10000000000, 15);//functin call-3

            //10 + 20
            //"joy" + "dip"

            Person obj1 = new Person("anil");
            Person obj2 = new Person("anil");
            if (obj1 != obj2)
            {
                Console.WriteLine("not same");
            }
            else
                Console.WriteLine("same");
            */
        }
    }
}
