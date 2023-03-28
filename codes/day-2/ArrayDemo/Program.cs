using System;

namespace ArrayDemo
{
    internal class Program
    {
        static void CreateSingleDimensionalArray()
        {
            //Array (single - dimensional array)
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                //string interpolation (C# 6.0 - 2015)
                Console.Write($"enter value at numbers[{i}]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            //read-only itertaor
            //duing this iteration you can't delete any value or add a new value
            //you can just update the value
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Value at numbers[{i}]:{numbers[i]}");
            }
            Console.WriteLine("\n");
            string[] people = new string[3];
            for (int i = 0; i < people.Length; i++)
            {
                Console.Write($"enter value at people[{i}]: ");
                people[i] = Console.ReadLine();
            }
            Console.WriteLine("\n");
            foreach (string name in people)
            {
                Console.WriteLine(name);
            }
        }
        static void CreateTwoDimensionalArray()
        {
            //two-dimensional array
            int[,] values = new int[3, 2];

            //Console.WriteLine(values.Rank);
            //Console.WriteLine(values.GetLength(0));
            //Console.WriteLine(values.GetLength(1));

            //pass the numer indicating dimension value (1st Dimension: 0, 2nd Dimension: 1, ....) to the GetLength() method
            for (int rowIndex = 0; rowIndex < values.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < values.GetLength(1); columnIndex++)
                {
                    Console.Write($"enter value at values[{rowIndex},{columnIndex}]: ");
                    values[rowIndex, columnIndex] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            for (int rowIndex = 0; rowIndex < values.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < values.GetLength(1); columnIndex++)
                {
                    Console.WriteLine($"value at values[{rowIndex},{columnIndex}]: {values[rowIndex, columnIndex]}");
                }
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            //CreateSingleDimensionalArray();
            //CreateTwoDimensionalArray();
        }
    }
}
