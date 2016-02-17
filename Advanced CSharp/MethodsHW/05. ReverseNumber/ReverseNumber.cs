namespace ReverseNumber
{
    using System;

    public class ReverseNumber
    {
        public static void Main()
        {
            double reversed = GetReversedNumber(123.45);
            Console.WriteLine(reversed);
        }

        private static double GetReversedNumber(double number)
        {
            double result = double.Parse(ReverseString(number.ToString()));
            
            return result;
        }

        private static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            
            return result;
        }
    }
}
