

namespace Nested_Dictionaries_Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, HashSet<int>>();
            var inputLine = Console.ReadLine().Split();
            while (inputLine[0] != "Aggregate")
            {

                var region = inputLine[0];
                var shell = int.Parse(inputLine[1]);
                if (!dictionary.ContainsKey(region))
                {
                    dictionary[region] = new HashSet<int>();
                }
                dictionary[region].Add(shell);
                inputLine = Console.ReadLine().Split();
            }
            foreach (var regionAndShell in dictionary)
            {
                var region = regionAndShell.Key;
                var shells = regionAndShell.Value;
                var sum = regionAndShell.Value.Sum();
                var count = regionAndShell.Value.Count;
                var giantShell = (int)(sum - sum / count);
                if (count > 1)
                {
                    Console.WriteLine($"{region} -> {string.Join(", ", shells)} ({giantShell})");
                }
                else
                {
                    Console.WriteLine($"{region} -> {string.Join(", ", shells)} ({sum})");
                }


            }
        }
    }
}
