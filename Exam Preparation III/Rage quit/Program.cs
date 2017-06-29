using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rage_quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var pattern = @"(\D+)(\d+)";
            var regex = new Regex(pattern);
            var matches = regex.Matches(inputLine);
            var result = new StringBuilder();

            foreach (Match match in matches)
            {
                var symbols = match.Groups[1].ToString();
                var count = int.Parse(match.Groups[2].ToString());
                for (int i = 0; i < count; i++)
                {
                    result.Append(symbols.ToUpper());
                }
            }
            var uniqueSymbols = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(result);
        }
    }
}
