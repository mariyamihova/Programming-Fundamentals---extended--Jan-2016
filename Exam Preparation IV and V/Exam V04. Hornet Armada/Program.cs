using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_V04.Hornet_Armada
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var legionAndActivity = new Dictionary<string, int>();
            var legionAndSoldiers = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();
                var splittedInput = inputLine.Split(new[] { ' ', '=', '>', ':', '-' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                var lastActivity = int.Parse(splittedInput[0]);
                var legionName = splittedInput[1];
                var soldierType = splittedInput[2];
                var soldierCount = long.Parse(splittedInput[3]);

                if (!legionAndActivity.ContainsKey(legionName))
                {
                    legionAndActivity[legionName] = lastActivity;
                    legionAndSoldiers.Add(legionName, new Dictionary<string, long>());
                }

                var savedActivity = legionAndActivity[legionName];
                if (savedActivity < lastActivity)
                {
                    legionAndActivity[legionName] = lastActivity;
                }


                if (!legionAndSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionAndSoldiers[legionName].Add(soldierType, 0);
                }

                legionAndSoldiers[legionName][soldierType] += soldierCount;

            }
            var secondLine = Console.ReadLine();
            var splitted = secondLine.Split('\\');
            if (splitted.Length >1)
            {

                var activity = int.Parse(splitted[0]);
                var type = splitted[1];

                foreach (var legionEntry in legionAndSoldiers.Where(x => x.Value.ContainsKey(type)).OrderByDescending(y => y.Value[type]))
                {

                    if (legionAndActivity[legionEntry.Key] < activity)
                    {
                        Console.WriteLine("{0} -> {1}", legionEntry.Key, legionAndSoldiers[legionEntry.Key][type]);
                    }
                }
            }
            else if (splitted.Length == 1)
            {
                var type = splitted[0];
                foreach (var legion in legionAndActivity.OrderByDescending(x => x.Value))
                {
                    if (legionAndSoldiers[legion.Key].ContainsKey(type))
                    {
                        Console.WriteLine("{0} : {1}", legion.Value, legion.Key);
                    }
                }
            }
        }
    }
}
