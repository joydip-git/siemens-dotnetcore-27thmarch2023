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
        static void CreateJaggedArray()
        {
            int[][] jagged = new int[3][];
            //jagged[0] = new int[] { 10, 20, 30 };
            //jagged[1] = new int[] { 11, 22, 33, 44, 55 };
            //jagged[2] = new int[] { 12, 13 };
            for (int index = 0; index < jagged.Length; index++)
            {
                Console.Write($"enter the size of new array#{index + 1}: ");
                int size = int.Parse(Console.ReadLine());
                int[] newArray = new int[size];
                jagged[index] = newArray;
            }

            for (int index = 0; index < jagged.Length; index++)
            {
                for (int i = 0; i < jagged[index].Length; i++)
                {
                    Console.Write($"\nenter value in jagged[{index}][{i}]: ");
                    jagged[index][i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n");
            }

            for (int index = 0; index < jagged.Length; index++)
            {
                for (int i = 0; i < jagged[index].Length; i++)
                {
                    Console.WriteLine($"value at jagged[{index}][{i}]: {jagged[index][i]}");
                }
                Console.WriteLine("\n");
            }
        }
        static int CalculateAverage(string name, params int[] marks)
        {
            int sum = 0;
            foreach (int item in marks)
            {
                sum += item;
            }
            return sum / marks.Length;
        }
        static void Main(string[] args)
        {
            //CreateSingleDimensionalArray();
            //CreateTwoDimensionalArray();
            //CreateJaggedArray();
            //params int[] numbers = new int[] { 10, 20, 30 };
            Console.WriteLine(CalculateAverage("anil", 20, 30));
            Console.WriteLine(CalculateAverage("sunil", 20, 30, 40));
            Console.WriteLine(CalculateAverage("ankush", 20, 30, 40, 50, 60));
        }
    }
}
