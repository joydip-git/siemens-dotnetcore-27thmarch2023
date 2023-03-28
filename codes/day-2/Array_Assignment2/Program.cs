using System;

namespace Array_Assignment2
{
    internal class Program
    {
        static int EnterMatrixSize()
        {
            Console.Write("enter the size of matrix array: ");
            return int.Parse(Console.ReadLine());
        }
        static void EnterValuesInMatrixArray(int[,] matrixArray)
        {
            for (int rowIndex = 0; rowIndex < matrixArray.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < matrixArray.GetLength(1); columnIndex++)
                {
                    Console.Write($"\nEner value at matrixArray[{rowIndex},{columnIndex}]: ");
                    matrixArray[rowIndex, columnIndex] = int.Parse(Console.ReadLine());
                }
            }
        }
        static int[] CreateSingleDimensionalArray(int[,] input)
        {
            int[] singleArray = new int[input.Length];
            int index = 0;
            for (int rowIndex = 0; rowIndex < input.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < input.GetLength(1); columnIndex++)
                {
                    singleArray[index] = input[rowIndex, columnIndex];
                    index++;
                }
            }
            return singleArray;
        }
        static int[] ConvertToSingleDimensionalArray(int[,] input)
        {
            int[] singleArray = CreateSingleDimensionalArray(input);
            Array.Sort(singleArray);

            int[] result = new int[singleArray.Length];
            int middleIndex = result.Length / 2;
            result[middleIndex] = singleArray[0];
            int leftCounter = 1;
            int rightCounter = 1;

            for (int i = 1; i < singleArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result[middleIndex + rightCounter] = singleArray[i];
                    rightCounter++;
                }
                else
                {
                    result[middleIndex - leftCounter] = singleArray[i];
                    leftCounter++;
                }
            }

            return result;
        }

        static void Main()
        {
            int size = EnterMatrixSize();
            int[,] arr = new int[size, size];
            EnterValuesInMatrixArray(arr);
            int[] result = ConvertToSingleDimensionalArray(arr);
            foreach (int item in result)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
