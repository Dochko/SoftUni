namespace SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfLetters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(.)\1+");

            Console.WriteLine(regex.Replace(input, "$1"));
        }
    }
}
