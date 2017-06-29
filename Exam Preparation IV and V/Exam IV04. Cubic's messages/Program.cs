using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam_IV04.Cubic_s_messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = Console.ReadLine();
            

            while (message!="Over!")
            {
                var number = int.Parse(Console.ReadLine());
                var pattern = new Regex(@"^([0-9]+)([a-zA-Z]{" + number + @"})([^a-zA-Z]*)$");
                var match = pattern.Match(message);
                if (match.Success)
                {
                    var decryptedMessage = match.Groups[2].ToString();
                    Console.Write(decryptedMessage + " == ");
                    var indexes = GetIndexes(match);
                    foreach (var index in indexes)
                    {
                        if (index>=0&&index<decryptedMessage.Length)
                        {
                            Console.Write(decryptedMessage[index]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                      
                    }
                    Console.WriteLine();
                }


                message = Console.ReadLine();
                
            }
        }

        private static List<int> GetIndexes(Match match)
        {
            var indexes = new List<int>();
            var leftindexes = match.Groups[1].ToString();
            for (int i = 0; i < leftindexes.Length; i++)
            {
                if (char.IsDigit(leftindexes[i]))
                {
                    indexes.Add(int.Parse(leftindexes[i].ToString()));
                }
            }

            var rightindexes = match.Groups[3].ToString();
            for (int i = 0; i < rightindexes.Length; i++)
            {
                if (char.IsDigit(rightindexes[i]))
                {
                    indexes.Add(int.Parse(rightindexes[i].ToString()));
                }
            }
            return indexes;
        }
    }
}
