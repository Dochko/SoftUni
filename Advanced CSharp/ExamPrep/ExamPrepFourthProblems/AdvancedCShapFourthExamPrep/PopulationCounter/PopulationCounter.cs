namespace PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            IDictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            string command = Console.ReadLine();

            while (command != "report")
            {
                string[] commandArgs = command.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                var country = commandArgs[1]; 
                var town = commandArgs[0];
                var population = long.Parse(commandArgs[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                }
                
                countries[country].Add(town, population);

                command = Console.ReadLine();
            }

            var sortedCountries = countries
                .OrderByDescending(x => x.Value.Sum(y => y.Value));

            foreach (var countryInfo in sortedCountries)
            {
                long totalPopulation = countryInfo.Value.Sum(y => y.Value);

                Console.WriteLine(
                    "{0} (total population: {1})", 
                    countryInfo.Key,
                    totalPopulation);

                var orderedCityData = countryInfo.Value.OrderByDescending(y => y.Value);

                foreach (var city in orderedCityData)
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}