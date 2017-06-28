


namespace _03.Forum_Topics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var dicitionary = new Dictionary<string, HashSet<string>>();

            while (inputLine[0] != "filter")
            {
                var secondPart = inputLine[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var element in secondPart)
                {
                    if (!dicitionary.ContainsKey(inputLine[0]))
                    {
                        dicitionary[inputLine[0]] = new HashSet<string>();
                    }
                    dicitionary[inputLine[0]].Add(element);

                }
                inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }
            var tags = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var pair in dicitionary)
            {
                var topic = pair.Key;
                var list = pair.Value;
                bool IsContains = true;
                foreach (var element in tags)
                {
                    if (list.Contains(element))
                    {
                        IsContains = true;
                    }
                    else
                    {
                        IsContains = false;
                        break;
                    }
                }

                if (IsContains)
                {
                    Console.WriteLine($"{topic} | #{string.Join(", #", list)}");
                }
            }

        }
    }
