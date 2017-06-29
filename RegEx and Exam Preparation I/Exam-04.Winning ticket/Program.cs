using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam_04.Winning_ticket
{
    class WinningTicket
    {
        static void Main()
        {
            var input= Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

            foreach (var ticket in input)
            {
                var length = ticket.Length;
                if (length==20)
                {
                    var firstPart = ticket.Substring(0, 10);
                    var secondPart = ticket.Substring(10,10);

                    var pattern = @"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}";
                    var regex = new Regex(pattern);

                    var isFirstMatch = regex.IsMatch(firstPart);
                    var isSecondMatch = regex.IsMatch(secondPart);

                    if (isFirstMatch && isSecondMatch)
                    {
                        var firstPartMatch = regex.Match(firstPart);

                        var secondPartMatch = regex.Match(secondPart);


                        if (firstPartMatch.ToString() == secondPartMatch.ToString())
                        {
                            if (firstPartMatch.Length >= 6 && firstPartMatch.Length < 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {firstPartMatch.Length}{firstPartMatch.ToString()[0]}");
                            }
                            else if (firstPartMatch.Length == 10&& secondPartMatch.Length==10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - 10{firstPartMatch.ToString()[0]} Jackpot!");
                            }
                           
                        }
                        else
                        {
                            var shorterMatch = Math.Min(firstPartMatch.Length, secondPartMatch.Length);
                            Console.WriteLine($"ticket \"{ticket}\" - {shorterMatch}{firstPartMatch.ToString()[0]}");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
