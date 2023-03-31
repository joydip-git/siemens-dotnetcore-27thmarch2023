using System;
using System.Collections.Generic;

namespace DelegateAssignment
{
    internal class Program
    {
        static List<int> Filter(List<int> input)
        {
            return null;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //Filter all even numbers
            List<int> evenNumbers = Filter(numbers);
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            //Filter odd even numbers
            List<int> oddNumbers = Filter(numbers);
            foreach (int number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
