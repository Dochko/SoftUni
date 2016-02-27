namespace RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main(string[] args)
        {
            const string Pattern = @"(\D+)(\d+)";
            var pairMatcher = new Regex(Pattern);

            string input = Console.ReadLine();
            var pair = pairMatcher.Matches(input);
            StringBuilder stringBuilder = new StringBuilder();

            //do
            //{
            //    string str = pair.Groups[1].ToString().ToUpper();
            //    int count = int.Parse(pair.Groups[2].Value);

            //    for (int i = 0; i < count; i++)
            //    {
            //        stringBuilder.Append(str);
            //    }

            //    pair = pair.NextMatch();
            //}
            //while (pair.Success);

            foreach (Match variable in pair)
            {
                for (int i = 0; i < int.Parse(variable.Groups[2].Value); i++)
                {
                    stringBuilder.Append(variable.Groups[1].ToString().ToUpper());
                }
            }

            Console.WriteLine("Unique symbols used: {0}", stringBuilder.ToString().Distinct().Count());
            Console.WriteLine(stringBuilder);
        }
    }
}