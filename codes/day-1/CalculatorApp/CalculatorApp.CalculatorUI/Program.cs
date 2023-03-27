using System;
using CalculatorApp.CalculaionLibrary;
//static import
using static CalculatorApp.CalculatorUI.Utility.UiUtility;

namespace CalculatorApp.CalculatorUI
{
    internal class Program
    {
        static void Main()
        {
            Calculation calculation = new Calculation();
            PrintMenu();
            int choice = AskForChoice();
            int firstValue = EnterValue();
            int secondValue = EnterValue();
        }
    }
}
