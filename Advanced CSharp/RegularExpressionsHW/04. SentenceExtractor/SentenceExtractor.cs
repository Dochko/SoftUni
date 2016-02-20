namespace SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractor
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            MatchCollection matches = IsSentence(text);

            foreach (Match sentence in matches)
            {
                string sentenceToCheck = sentence.ToString();
                if (IsWordInSentence(sentenceToCheck, word))
                {
                    Console.WriteLine(sentenceToCheck.Trim());
                }
            }
        }

        private static bool IsWordInSentence(string sentence, string word)
        {
            return Regex
                .Matches(sentence, string.Format(@"\b{0}\b", word), RegexOptions.IgnoreCase)
                .Count != 0;
        }

        private static MatchCollection IsSentence(string text)
        {
            string pattern = @"([^.!?]+(?=[.!?])[.!?])";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            
            return matches;
        }
    }
}