
namespace _04.CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            var data = new Dictionary<string, List<int>>();
            while (inputLine[0] != "chop")
            {
                var treeType = inputLine[0];
                var treeLenght = int.Parse(inputLine[1]);
                if (!data.ContainsKey(treeType))
                {
                    data[treeType] = new List<int>();
                }
                data[treeType].Add(treeLenght);

                inputLine = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            var treeToBeUsed = Console.ReadLine();
            var minimumLength = int.Parse(Console.ReadLine());

            double pricePerMeter = Math.Round(data.SelectMany(x => x.Value).Sum() / (double)data.SelectMany(x => x.Value).Count(), 2);
            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");

            double usedLogs = data
                .Where(x => x.Key == treeToBeUsed)
                .SelectMany(x => x.Value)
                .Where(x => x >= minimumLength)
                .Sum();
            double usedLogsPrice = Math.Round(usedLogs * pricePerMeter, 2);
            Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");

            double unusedLogs = data
                .Where(x => x.Key != treeToBeUsed)
                .SelectMany(x => x.Value)
                .Sum();

            double unusedLogsSmallerTrees = data
                .Where(x => x.Key == treeToBeUsed)
                .SelectMany(x => x.Value)
                .Where(x => x < minimumLength)
                .Sum();

            double unusedLogsPrice = Math.Round(((unusedLogs + unusedLogsSmallerTrees) * pricePerMeter * 0.25), 2);
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:f2}");

            double totalPrice = usedLogsPrice + unusedLogsPrice;
            Console.WriteLine($"CottageScraper subtotal: ${totalPrice:f2}");
        }
    }
    }

