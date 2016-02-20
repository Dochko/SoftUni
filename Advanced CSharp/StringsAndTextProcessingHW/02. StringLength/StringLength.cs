namespace StringLength
{
    using System;

    public class StringLength
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string output = input.Length > 20 
                ? input.Substring(0, 20) 
                : input.PadRight(20, '*');

            Console.WriteLine(output);
        }
    }
}
