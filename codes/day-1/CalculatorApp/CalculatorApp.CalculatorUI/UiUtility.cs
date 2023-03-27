using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.CalculatorUI.Utility
{
    internal static class UiUtility
    {
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
    }
}
