namespace ReverseString
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(string.Join(string.Empty, input.Reverse()));
        }
    }
}
