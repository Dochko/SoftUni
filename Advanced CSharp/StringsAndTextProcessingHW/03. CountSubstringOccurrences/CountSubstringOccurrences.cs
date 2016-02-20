namespace CountSubstringOccurrences
{
    using System;
    using System.Linq;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string substringToSearch = Console.ReadLine();

            int count = input
                .Select((c, i) => input.Substring(i))
                .Count(x => x.StartsWith(substringToSearch, StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine(count);
        }
    }
}
