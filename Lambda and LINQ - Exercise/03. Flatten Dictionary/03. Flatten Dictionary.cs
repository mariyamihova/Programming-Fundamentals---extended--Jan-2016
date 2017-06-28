

namespace _03.Flatten_Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split(' ');
            var data = new Dictionary<string, Dictionary<string, string>>();
            while (inputLine[0] != "end")
            {
                if (inputLine[0] != "flatten")
                {
                    var key = inputLine[0];
                    var innerKey = inputLine[1];
                    var innerValue = inputLine[2];
                    if (!data.ContainsKey(key))
                    {
                        data.Add(key, new Dictionary<string, string>());
                    }
                    data[key][innerKey] = innerValue;
                }
                else
                {
                    var key = inputLine[1];
                    data[key] = data[key].ToDictionary(x => x.Key + x.Value, x => "flattend");
                }
                inputLine = Console.ReadLine().Split(' ');
            }
            var orderedData = data
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var entry in orderedData)
            {
                Console.WriteLine($"{entry.Key}");

                var orderedInnerDict = entry.Value
                    .Where(x => x.Value != "flattend")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattendValues = entry.Value
                    .Where(x => x.Value == "flattend")
                    .ToDictionary(x => x.Key, x => x.Value);
                var count = 1;
                foreach (var innerItem in orderedInnerDict)
                {
                    Console.WriteLine("{0}. {1} - {2}", count, innerItem.Key, innerItem.Value);
                    count++;
                }
                foreach (var flattendItem in flattendValues)
                {
                    Console.WriteLine("{0}. {1}", count, flattendItem.Key);
                    count++;
                }
            }
        }
    }
}
