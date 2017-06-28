


namespace _04.Group_Continents_Countries_and_Cities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split();
                var continent = inputLine[0];
                var country = inputLine[1];
                var city = inputLine[2];
                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new SortedSet<string>();
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
