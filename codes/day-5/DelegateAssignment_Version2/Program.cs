using System;
using System.Collections.Generic;

namespace DelegateAssignment
{
    delegate bool FilterDel<T>(T value);

    class Logic
    {
        public bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
        public bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        public bool IsGreaterThanFive(int num)
        {
            return num > 5;
        }
        //public bool IsLesserThanFive(int num)
        //{
        //    return num < 5;
        //}
    }
    internal class Program
    {
        static List<T> Filter<T>(List<T> input, FilterDel<T> filterDel)
        {
            List<T> result = new List<T>();
            foreach (T item in input)
            {
                bool isTrue = filterDel(item);
                if (isTrue)
                    result.Add(item);
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<string> people = new List<string> { "anil", "sunil", "joy", "sid", "abhi", "gurlal" };
            //filtter by names conaining l
            //FilterDel<string> nameDel = delegate (string name)
            //{
            //    return name.Contains('l');
            //};
            FilterDel<string> nameDel = (name) => name.Contains('l');
            List<string> filteredPeople = Filter<string>(people, nameDel);
            Console.WriteLine("--filtered names---");
            foreach (string name in filteredPeople)
            {
                Console.WriteLine(name);
            }

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            Logic logic = new Logic();
            //Filter all even numbers
            FilterDel<int> evenDel = new FilterDel<int>(logic.IsEven);
            List<int> evenNumbers = Filter<int>(numbers, evenDel);
            Console.WriteLine("\n\n----Even Numbers----");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            // Filter numbers less than 5
            // public bool IsLesserThanFive(int num)
            // Anonymous Method (C# 2.0 - 2005) with delegate
            FilterDel<int> lesserDel = delegate (int number)
            {
                return number < 5;
            };

            List<int> lesserNumbers = Filter<int>(numbers, lesserDel);
            Console.WriteLine("\n----Lesser Numbers----");
            foreach (int number in lesserNumbers)
            {
                Console.WriteLine(number);
            }

            // Filter numbers which are divisile by 3
            // public bool IsDivisibleThree(int num)
            // Lambda Expression (C# 3.0 - 2007): short hand notation of writing anonymous method
            // => Lambda Operator
            //FilterDel divisibleDel = (number) => number % 3 == 0 ? true : false;
            FilterDel<int> divisibleDel = (number) => number % 3 == 0;
            //{
            //    return number % 3 == 0;
            //};

            List<int> divisibleNumbers = Filter<int>(numbers, divisibleDel);
            Console.WriteLine("\n----Divisible Numbers----");
            foreach (int number in divisibleNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
