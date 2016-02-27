namespace TextTransformer
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class TextTransformer
    {
        public static void Main()
        {
            const string Pattern = @"([$%&'])([^$%&']+)\1";
            var symbolDictionary = new Dictionary<char, int>
            {
                { '$', 1 },
                { '%', 2 },
                { '&', 3 },
                { '\'', 4 }
            };

            StringBuilder stringBuilder = new StringBuilder();
            string input;
            while ((input = Console.ReadLine()) != "burp")
            {
                stringBuilder.Append(input);
            }

            var text = Regex.Replace(stringBuilder.ToString(), @"\s+", " ");
            var regex = new Regex(Pattern);
            var matches = regex.Matches(text);

            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
                char specialSymbol = match.Groups[1].Value[0];
                string capturedString = match.Groups[2].Value;

                for (int i = 0; i < capturedString.Length; i++)
                {
                    char currentSymbol = capturedString[i];
                    char resultSymbol;

                    if (i % 2 == 0)
                    {
                        resultSymbol = (char)(currentSymbol + symbolDictionary[specialSymbol]);
                    }
                    else
                    {
                        resultSymbol = (char)(currentSymbol - symbolDictionary[specialSymbol]);
                    }

                    result.Append(resultSymbol);
                }

                result.Append(" ");
            }

            Console.WriteLine(result.ToString());
        }
    }
}