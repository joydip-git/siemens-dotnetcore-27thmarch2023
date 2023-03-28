using System;
using CalculatorApp.CalculaionLibrary;
//static import (6.0 - 2015)
using static CalculatorApp.CalculatorUI.Utility.UiUtility;

namespace CalculatorApp.CalculatorUI
{
    internal class Program
    {
        static void Main()
        {
            char toContinue = 'n';
            do
            {
                Calculation calculationObjRef = null;
                calculationObjRef = new Calculation();
                PrintMenu();
                int choice = AskForChoice();
                int firstValue = EnterValue();
                int secondValue = EnterValue();
                //named arguments (4.0 - 2010)
                int? result;
                CallCalculationMethod(firstNumber: firstValue, secondNumber: secondValue, calcChoice: choice, calculaion: calculationObjRef, result: out result);
                if (!result.HasValue)
                    Console.WriteLine("no calculation took place");
                else
                    Console.WriteLine(result.Value);

                DecideToContinue(ref toContinue);
            } while (toContinue != 'n');
        }
    }
}
