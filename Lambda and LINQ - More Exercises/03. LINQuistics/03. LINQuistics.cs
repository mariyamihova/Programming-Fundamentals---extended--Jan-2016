
namespace _03.LINQuistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var result = new Dictionary<string, HashSet<string>>();
            var inputLine = Console.ReadLine().Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);

            while (inputLine[0] != "exit")
            {
                if (inputLine.Length > 1)
                {
                    var collectionName = inputLine[0];
                    var methods = inputLine.ToList();

                    if (!result.ContainsKey(collectionName))
                    {
                        result.Add(collectionName, new HashSet<string>());
                    }

                    for (int i = 1; i < methods.Count; i++)
                    {
                        result[collectionName].Add(methods[i].Trim(new char[] { '(', ')' }));
                    }

                }
                else
                {
                    int number = 0;
                    if (Int32.TryParse(inputLine[0], out number) && result.Count > 0)
                    {
                        var orderedValues = result.Values.OrderByDescending(x => x.Count()).First().OrderBy(x => x.Length).Take(number).ToList();

                        foreach (var methodName in orderedValues)
                        {
                            if (orderedValues.Count > 0)
                            {
                                Console.WriteLine($"* {methodName}");
                            }
                        }
                    }
                    else if (result.ContainsKey(inputLine[0]))
                    {
                        var orderedValues = result[inputLine[0]].OrderByDescending(x => x.Length).ThenByDescending(x => x.Distinct().Count()).ToList();
                        foreach (var methodName in orderedValues)
                        {
                            Console.WriteLine($"* {methodName}");
                        }
                    }



                }
                inputLine = Console.ReadLine().Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            }

            var lastLine = Console.ReadLine().Split(' ');
            var method = lastLine[0];
            var selection = lastLine[1];
            if (selection == "collection")
            {
                foreach (var collection in result.Where(x => x.Value.Contains(method)).OrderByDescending(x => x.Value.Count()).ThenByDescending(x => x.Value.Min(y => y.Length)))
                {
                    Console.WriteLine(collection.Key);
                }
            }
            else
            {
                foreach (var collection in result.Where(x => x.Value.Contains(method)).OrderByDescending(x => x.Value.Count()).ThenByDescending(x => x.Value.Min(y => y.Length)))
                {
                    Console.WriteLine(collection.Key);
                    foreach (var methodName in collection.Value.OrderByDescending(x => x.Count()))
                    {
                        Console.WriteLine($"* {methodName}");
                    }
                }
            }
        }
    }
}
