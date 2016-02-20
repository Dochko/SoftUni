namespace ExtractEmails
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match email in matches)
            {
                Console.WriteLine(string.Format(email.Groups[1].ToString()));
            }
        }
    }
}
