using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(?<!\d)(10|[2-9]|[JKQA])([SHDC])";
            var regex = new Regex(pattern);
            var matches = regex.Matches(input);
            var result = new List<string>();

            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
