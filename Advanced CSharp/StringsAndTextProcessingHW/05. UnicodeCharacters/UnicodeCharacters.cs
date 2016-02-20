namespace UnicodeCharacters
{
    using System;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            foreach (var chr in input)
            {
                Console.Write("\\u{0:x4}", (int)chr);
            }
            
            Console.WriteLine();
        }
    }
}
