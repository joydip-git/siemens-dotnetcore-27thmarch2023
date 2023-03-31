using System;
using System.Reflection;

namespace DelegatesBasic
{
    //1.
    delegate void CalculationDel(int x, int y);
    delegate int MultiplyDel(int f, int s);
    /*
    class CalculationDel:MulticastDelegate
    {
        object _target;
        MethodInfo _method;

        public CalculationDel(object target, MethodInfo method)
        {
            _target = target;
            _method = method;
        }
        public void Invoke(int x, int y)
        {
            _method.Invoke(_target, new object[] { x, y });
        }
    }
    */
    class Calculation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single-cast delegate
            //2.A. store reference/address of function
            //a. instance function
            Calculation calc = new Calculation();
            CalculationDel subtractDel = new CalculationDel(calc.Subtract);

            //b. static function
            CalculationDel addDel = new CalculationDel(Calculation.Add);

            //2.B. invoke the function using delegate
            //subtractDel.Invoke(10, 2);
            //addDel(10, 20);
            InvokeMethods(subtractDel);
            InvokeMethods(addDel);

            Console.WriteLine("\n\n");

            //Multi-cast delegate
            //3.A. store references/addresses of functions
            CalculationDel multiDel = new CalculationDel(calc.Subtract);
            //multiDel += new CalculationDel(Calculation.Add);
            multiDel += Calculation.Add;

            //3.B.invoke the functions using delegate
            //multiDel.Invoke(10, 2);
            //multiDel(10, 2);
            InvokeMethods(multiDel);

            //Multiply function signature does not match the delegate signature, hence can't call using this delegate
            //CalculationDel multiplyDel = new CalculationDel(calc.Multiply);

            MultiplyDel md = new MultiplyDel(calc.Multiply);
            md += Calculation.Divide;
            int result = md(10, 2);
            //Delegate[] all = md.GetInvocationList();
            //foreach (Delegate d in all)
            //{
            //    d.DynamicInvoke(10, 2);
            //}
            Console.WriteLine(result);

        }
        static void InvokeMethods(CalculationDel cd)
        {
            cd(10, 2);
        }
    }
}
