using System;

namespace CalculatorApp.CalculaionLibrary
{
    /// <summary>
    /// class containing calculation methods
    /// </summary>
    public class Calculation
    {
        /// <summary>
        /// method to add two numbers
        /// </summary>
        /// <param name="first">first number to be passed</param>
        /// <param name="second">second number to be passed</param>
        /// <returns>
        /// returns the added result 
        /// </returns>
        public int Add(int first, int second)
        {
            return first + second;
        }

        /// <summary>
        /// method to subtract a number from another
        /// </summary>
        /// <param name="first">first number to be passed</param>
        /// <param name="second">second number to be passed</param>
        /// <returns>
        /// returns the subtraction result 
        /// </returns>
        public int Subtract(int first, int second)
        {
            return first - second;
        }

        /// <summary>
        /// method to multtiply a number by another
        /// </summary>
        /// <param name="first">first number to be passed</param>
        /// <param name="second">second number to be passed</param>
        /// <returns>
        /// returns the multiplication result 
        /// </returns>
        public int Multiply(int first, int second)
        {
            return first * second;
        }
        /// <summary>
        /// method to divide a number by another
        /// </summary>
        /// <param name="first">first number to be passed</param>
        /// <param name="second">second number to be passed</param>
        /// <exception cref="ArgumentException">
        /// throws argument exception if the second argument is zero
        /// </exception>
        /// <returns>
        /// returns the division result 
        /// </returns>
        public int Divide(int first, int second)
        {
            if (second == 0)
                throw new ArgumentException("the second argument-denominator, should not be zero");
            return first / second;
        }
    }
}
