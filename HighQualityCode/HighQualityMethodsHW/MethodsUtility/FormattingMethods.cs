namespace Methods.MethodsUtility
{
    using System;

    /// <summary>
    /// Contains methods for formatting.
    /// </summary>
    public static class FormattingMethods
    {
        /// <summary>
        /// Prints the text representation of the digits from 0-9.
        /// </summary>
        /// <param name="number">The digit.</param>
        /// <returns>String representation of the given digit.</returns>
        public static string DigitToText(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "Invalid digit!";
            }
        }

        /// <summary>
        /// Formats a number according the given input string.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="format">The format string.</param>
        /// <exception cref="ArgumentException">format;Wrong format string !</exception>
        public static void PrintFormattedNumber(object number, string format)
        {
            string formatString = format.ToLower();

            switch (formatString)
            {
                case "f":
                    Console.WriteLine("{0:f2}", number);
                    break;
                case "%":
                    Console.WriteLine("{0:p0}", number);
                    break;
                case "r":
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException("format", "Wrong format string !");
            }
        }
    }
}