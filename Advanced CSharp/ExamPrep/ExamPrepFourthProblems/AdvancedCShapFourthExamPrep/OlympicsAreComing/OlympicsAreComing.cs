namespace OlympicsAreComing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class OlympicsAreComing
    {
        public static void Main()
        {
            const string SplitPattern = @"\s*\|\s*";
            Regex regex = new Regex(SplitPattern);
            var countryInfo = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "report")
            {
                string[] tokens = regex.Split(command.Trim());
                string participant = Regex.Replace(tokens[0].Trim(), @"\s+", " ");
                string country = Regex.Replace(tokens[1].Trim(), @"\s+", " ");

                if (!countryInfo.ContainsKey(country))
                {
                    countryInfo.Add(country, new List<string>());
                }

                countryInfo[country].Add(participant);

                command = Console.ReadLine();
            }

            var orderedCountryInfo = countryInfo.OrderByDescending(x => x.Value.Count);

            foreach (var country in orderedCountryInfo)
            {
                Console.WriteLine(
                    "{0} ({1} participants): {2} wins",
                    country.Key,
                    country.Value.Distinct().Count(),
                    country.Value.Count);
            }
        }
    }
}