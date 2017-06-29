using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var result = new Dictionary<string, Dictionary<string, long>>();
            while (inputLine != "quit")
            {
                var splittedInput = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                var wormName = splittedInput[0];
                var teamName = splittedInput[1];
                var wormScore = long.Parse(splittedInput[2]);


                if (result.Any(x => x.Value.ContainsKey(wormName)))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                if (!result.ContainsKey(teamName))
                {
                    result[teamName] = new Dictionary<string, long>();
                }

                if (!result[teamName].ContainsKey(wormName))
                {
                    result[teamName].Add(wormName, wormScore);
                }

                inputLine = Console.ReadLine();

            }

            var count = 1;
            foreach (var pair in result.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Sum() / x.Value.Count))
            {
                var wormsWithScores = pair.Value;
                Console.WriteLine($"{count}. Team: {pair.Key} - {pair.Value.Values.Sum()}");
                count++;
                foreach (var worm in wormsWithScores.OrderByDescending(w => w.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
            }
        }
    }
}

        }
    }
}
