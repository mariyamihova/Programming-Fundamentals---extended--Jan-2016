using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fish_Statistics
{
    class FishStatistic
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"(>*)(<)(\({1,})(['\-x])(>)";
            var regex = new Regex(pattern);

            var matches = regex.Matches(input);
            var count = 1;
            if (matches.Count == 0)
            {
                Console.WriteLine("No fish found.");
            }
            else
            {
                foreach (Match match in matches)
                {

                    Console.WriteLine("Fish {0}: {1}", count, match.Groups[0]);
                    var tailLength = match.Groups[1].Length;
                    if (tailLength > 5)
                    {
                        Console.WriteLine("  Tail type: Long ({0} cm)", tailLength * 2);
                    }
                    else if (tailLength > 1 && tailLength <= 5)
                    {
                        Console.WriteLine("  Tail type: Medium ({0} cm)", tailLength * 2);
                    }
                    else if (tailLength == 1)
                    {
                        Console.WriteLine("  Tail type: Short ({0} cm)", tailLength * 2);
                    }
                    else 
                    {
                        Console.WriteLine("  Tail type: None");
                    }

                    var bodyType = match.Groups[3].Length;

                    if (bodyType > 10)
                    {
                        Console.WriteLine("  Body type: Long ({0} cm)", bodyType * 2);
                    }
                    else if (bodyType >5 && bodyType <= 10)
                    {
                        Console.WriteLine("  Body type: Medium ({0} cm)", bodyType * 2);
                    }
                    else if(bodyType<=5)
                    {
                        Console.WriteLine("  Body type: Short ({0} cm)", bodyType * 2);
                    }

                    var status = match.Groups[4].ToString();

                    if (status == "x")
                    {
                        Console.WriteLine("  Status: Dead");
                    }
                    else if (status == "'")
                    {
                        Console.WriteLine("  Status: Awake");
                    }
                    else if (status == "-")
                    {
                        Console.WriteLine("  Status: Asleep");
                    }
                    count++;
                }
            }
        }
    }
}
