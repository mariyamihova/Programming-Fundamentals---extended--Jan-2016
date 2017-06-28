

namespace _02.Cities_by_Continent_and_Country
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split();
                var continent = inputLine[0];
                var country = inputLine[1];
                var city = inputLine[2];
                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new Dictionary<string, List<string>>();
                }
                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new List<string>();
                }
                continentsData[continent][country].Add(city);

            }
            foreach (var continentCountries in continentsData)
            {
                var continentName = continentCountries.Key;
                var countries = continentCountries.Value;
                Console.WriteLine($"{continentName}:");
                foreach (var countryCities in countries)
                {
                    var countryname = countryCities.Key;
                    var cities = countryCities.Value;
                    Console.WriteLine("  {0} -> {1}", countryname, string.Join(", ", cities));
                }
            }
        }
    }
}
