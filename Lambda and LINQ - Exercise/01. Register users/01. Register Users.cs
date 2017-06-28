


namespace Lambda_and_LINQ_Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var data = new Dictionary<string, DateTime>();
            while (inputLine[0] != "end")
            {
                if (!data.ContainsKey(inputLine[0]))
                {
                    data[inputLine[0]] = new DateTime();
                }
                data[inputLine[0]] = DateTime.ParseExact(inputLine[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }
            var result = data
                .Reverse()
                .OrderBy(k => k.Value)
                .Take(5)
                .OrderByDescending(k => k.Value)
                .ToDictionary(k => k.Key, k => k.Value);


            if (result.Count <= 5)
            {


                foreach (var pair in result)
                {

                    var name = pair.Key;

                    Console.WriteLine(name);
                }
            }
            else
            {

                foreach (var pair in result)
                {
                    var name = pair.Key;
                    Console.WriteLine(name);
                }
            }

        }
    }
    }

