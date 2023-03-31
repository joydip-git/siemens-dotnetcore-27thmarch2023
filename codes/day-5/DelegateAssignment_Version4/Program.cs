using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateAssignment
{
    internal class Program
    {
        //delegate TResult Func<in T, out TResult>(T arg);
        //delegate bool Func<in string, out bool>(string arg);
        static void Main(string[] args)
        {
            List<string> people = new List<string> { "anil", "sunil", "joy", "sid", "abhi", "gurlal" };

            /*
            //Where method accepts object of Func<T,TResult>
            Func<string, bool> nameDel = (name) => name.Contains('l');
            //Equivalent to Filter method you created
            List<string> filteredPeople = people.Where(nameDel).ToList<string>();

            //print
            Action<string> printDel= (name) => Console.WriteLine(name);
            filteredPeople.ForEach(printDel);
            */

            //LINQ: Lanuage Integrated Query
            //Queying against a collecion using programming language features
            //OOP, new features, delegate, generics, collections
            people
                .Where(name => name.Contains('l'))
                .OrderBy(name => name[0]) 
                .ToList<string>()
                .ForEach(name => Console.WriteLine(name));
        }
    }
}
