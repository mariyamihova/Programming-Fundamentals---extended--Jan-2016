using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            var songsAvailable= Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

            var winners = new Dictionary<string, HashSet<string>>();

            var inputLine = Console.ReadLine();
            while (inputLine!="dawn")
            {
                var splittedInput=inputLine.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

                var singer = splittedInput[0];
                var song = splittedInput[1];
                var award = splittedInput[2];

                if (participants.Contains(singer) && songsAvailable.Contains(song))
                {
                    if (!winners.ContainsKey(singer))
                    {
                        winners[singer] = new HashSet<string>();
                    }
                    winners[singer].Add(award);

                }
               
               inputLine = Console.ReadLine();

            }
            if (winners.Count==0)
            {
                Console.WriteLine("No awards");
            }

            foreach (var pair in winners.OrderByDescending(x=>x.Value.Count).ThenBy(y=>y.Key))
            {
                Console.WriteLine("{0}: {1} awards", pair.Key, pair.Value.Count);
                foreach (var award in pair.Value.OrderBy(x=>x))
                {
                    Console.WriteLine("--{0}", award);
                }
            }
        }
    }
}
