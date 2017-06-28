


namespace _02.Default_Values
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var data = new Dictionary<string, string>();
            while (inputLine[0] != "end")
            {
                if (!data.ContainsKey(inputLine[0]))
                {
                    data[inputLine[0]] = string.Empty;
                }
                data[inputLine[0]] = inputLine[1];

                inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            var defaultValue = Console.ReadLine();

            var unchangedValues = data
                .Where(d => d.Value != "null")
                .OrderByDescending(d => d.Value.Length)
                .ToDictionary(d => d.Key, d => d.Value);
            foreach (var pair in unchangedValues)
            {
                Console.WriteLine($"{pair.Key} <-> {pair.Value}");

            }

            var changedValues = data
                .Where(d => d.Value == "null")
                .ToDictionary(d => d.Key, d => defaultValue);

            foreach (var pair in changedValues)
            {
                Console.WriteLine($"{pair.Key} <-> {pair.Value}");

            }

        }
    }
}
