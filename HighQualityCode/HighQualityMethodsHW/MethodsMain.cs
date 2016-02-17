namespace Methods
{
    using System;
    using Models;
    using Contracts;
    using static MethodsUtility.CalculationMethods;
    using static MethodsUtility.FormattingMethods;

    /// <summary>
    /// The main class of the project.
    /// </summary>
    public static class MethodsMain
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("The area of a triangle with sides 3, 4 and 5 is: " + CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine("The name of the digit is: " + DigitToText(5));
            
            Console.WriteLine("Max number: " + FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

            PrintFormattedNumber(1.3, "f");
            PrintFormattedNumber(0.75, "%");
            PrintFormattedNumber(2.30, "r");

            Console.WriteLine("Distance: " + CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal: " + IsHorizontalLine(3, 3));
            Console.WriteLine("Vertical : " + IsVerticalLine(-1, 2.5));

            IStudent peter = new Student("Peter", "Ivanov", "From Sofia, born at 17.03.1992");
            IStudent stella = new Student("Stella", "Markova", "From Vidin, gamer, high results, born at 03.11.1993");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}