using CalculatorApp.CalculaionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.CalculatorUI.Utility
{
    static class UiUtility
    {
        //const string NAME = "";
        //static string name;
        //static UiUtility() { }
        //public static string Name { set=>, get=>}
        public static void PrintMenu()
        {
            Console.WriteLine("1. Add\n2. Subtract\n3. Multiply\n4. Divide");
        }

        public static int AskForChoice()
        {
            Console.WriteLine("\nEnter Choice[1/2/3/4]: ");
            //Convert.ToInt32(Console.ReadLine());
            return int.Parse(Console.ReadLine());
        }

        public static int EnterValue()
        {
            Console.WriteLine("\nEnter a Number: ");
            return int.Parse(Console.ReadLine());
        }

        public static void CallCalculationMethod(int calcChoice, int firstNumber, int secondNumber, Calculation calculaion, out int? result)
        {
            //int? result = null;           
            switch (calcChoice)
            {
                case 1:
                    result = calculaion.Add(firstNumber, secondNumber);
                    break;

                case 2:
                    result = calculaion.Subtract(firstNumber, secondNumber);
                    break;

                case 3:
                    result = calculaion.Multiply(firstNumber, secondNumber);
                    break;

                case 4:
                    result = calculaion.Divide(firstNumber, secondNumber);
                    break;

                default:
                    Console.WriteLine("\nmake a correct choice");
                    result = null;
                    break;
            }
            //return result;
        }

        public static void DecideToContinue(ref char initial)
        {
            Console.WriteLine("\nWant to continue?[y/Y/n/N]: ");
            initial =  char.Parse(Console.ReadLine());
            if (char.IsUpper(initial))
            {
                initial = char.ToLower(initial);
            }
        }
    }
}
