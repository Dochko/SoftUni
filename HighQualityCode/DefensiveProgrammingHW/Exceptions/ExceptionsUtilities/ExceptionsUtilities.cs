namespace Exceptions.ExceptionsUtilities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExceptionsUtilities
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (startIndex <= 0 || startIndex >= arr.Length)
            {
                throw new ArgumentOutOfRangeException("startIndex", "The start index should be in the range of 0 ... arr.Length.");
            }

            if (count < 0 || count > arr.Length - startIndex)
            {
                throw new ArgumentOutOfRangeException("count", "The count should be in the range of 0 ... arr.Length - startIndex.");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("count", "The count should be in the range of 0 ... str.Length.");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    throw new Exception("The number is not prime!");
                }
            }

            return true;
        }
    }
}