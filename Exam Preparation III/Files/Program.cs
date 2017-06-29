using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, Dictionary<string, long>>();
            var IsInTheDict = false;

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                var root = inputLine[0];
                var secondPart = inputLine.Last().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                var fileName = secondPart[0];
                long size = long.Parse(secondPart[1]);

                if (!result.ContainsKey(root))
                {
                    result.Add(root, new Dictionary<string, long> { { fileName, size } });
                }

                else
                {
                    if (result[root].ContainsKey(fileName))
                    {
                        result[root][fileName] = size;
                    }
                    else
                    {
                        result[root].Add(fileName, size);
                    }
                }
            }
            var toFind = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            var extension = toFind[0];
            var folder = toFind[2];

            var filesWithExtension = result.Where(x => x.Key == folder).OrderByDescending(y => y.Value.Values);

            foreach (var pair in filesWithExtension)
            {
                var secondDictionary = pair.Value;
                foreach (var p in secondDictionary.OrderByDescending(x=>x.Value).ThenBy(y=>y.Key))
                {
                    if (p.Key.Split('.').Last()==extension)
                    {
                        Console.WriteLine($"{p.Key} - {p.Value} KB");
                        IsInTheDict = true; 
                    }
                   
                }
                
            }
            if (IsInTheDict==false)
            {
                Console.WriteLine("No");
            }

        }
    }
}
