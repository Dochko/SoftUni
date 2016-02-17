namespace SequencesOfEqualStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SequencesOfEqualStrings
    {
        public static void Main()
        {
            string[] stringArray = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, int> equalStrings = new Dictionary<string, int>();
            
            for (int index = 0; index < stringArray.Length; index++)
            {
                if (!equalStrings.ContainsKey(stringArray[index]))
                {
                    equalStrings.Add(stringArray[index], AppearanceCount(stringArray, stringArray[index]));
                }
            }

            foreach (KeyValuePair<string, int> pair in equalStrings)
            {
                string temp = pair.Key + " ";
                Console.WriteLine(string.Concat(Enumerable.Repeat(temp, pair.Value)));
            }
        }

        private static int AppearanceCount(string[] stringArray, string element)
        {
            int counter = stringArray.Count(c => c == element);

            return counter;
        } 
    }
}