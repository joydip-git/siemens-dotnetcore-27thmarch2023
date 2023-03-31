using System;
using System.Collections.Generic;

namespace DelegateAssignment
{
    delegate bool FilterDel(int value);

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
        static List<int> Filter(List<int> input, FilterDel filterDel)
        {
            List<int> result = new List<int>();
            foreach (int item in input)
            {
                bool isTrue = filterDel(item);
                if (isTrue)
                    result.Add(item);
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            Logic logic = new Logic();
            //Filter all even numbers
            FilterDel evenDel = new FilterDel(logic.IsEven);
            List<int> evenNumbers = Filter(numbers, evenDel);
            Console.WriteLine("----Even Numbers----");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            //Filter odd even numbers
            FilterDel oddDel = new FilterDel(logic.IsOdd);
            List<int> oddNumbers = Filter(numbers, oddDel);
            Console.WriteLine("\n----Odd Numbers----");
            foreach (int number in oddNumbers)
            {
                Console.WriteLine(number);
            }

            //Filter numbers greater than 5
            FilterDel greaterDel = new FilterDel(logic.IsGreaterThanFive);
            List<int> greaterNumbers = Filter(numbers, greaterDel);
            Console.WriteLine("\n----Greater Numbers----");
            foreach (int number in greaterNumbers)
            {
                Console.WriteLine(number);
            }

            // Filter numbers less than 5
            // public bool IsLesserThanFive(int num)
            // Anonymous Method (C# 2.0 - 2005) with delegate
            FilterDel lesserDel = delegate (int number)
            {
                return number < 5;
            };

            List<int> lesserNumbers = Filter(numbers, lesserDel);
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
            FilterDel divisibleDel = (number) => number % 3 == 0;
            //{
            //    return number % 3 == 0;
            //};

            List<int> divisibleNumbers = Filter(numbers, divisibleDel);
            Console.WriteLine("\n----Divisible Numbers----");
            foreach (int number in divisibleNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
