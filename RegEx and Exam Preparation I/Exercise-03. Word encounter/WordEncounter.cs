using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Word_encounter
{
    class WordEncounter
    {
        static void Main(string[] args)
        {
            var filter = Console.ReadLine();
            var firstPart = filter[0];
            var secondPart = int.Parse(filter[1].ToString());
            var inputLine = Console.ReadLine();
            var validSentences = new List<string>();
            var validWords = new List<string>();

            while (inputLine != "end")
            {

                var pattern = @"^[A-Z].*[.?!]$";
                var regex = new Regex(pattern);
                var isMatch = regex.IsMatch(inputLine);
                if (isMatch)
                {
                    var sentence = regex.Match(inputLine);
                    var secondPattern = @"\b\w+\b";
                    var secondRegex = new Regex(secondPattern);
                    var words = secondRegex.Matches(sentence.ToString());
                    foreach (Match word in words)
                    {
                        //if (word.Value.Contains(firstPart))
                        //{
                        //    var count = 0;
                        //    foreach (var letter in word.Value)
                        //    {
                        //        if (letter == firstPart)
                        //        {
                        //            count++;

                        //        }

                        //    }

                        var thirdPattern = $"{firstPart}";
                        var thirdRegex = new Regex(thirdPattern);
                        var count = thirdRegex.Matches(word.Value).Count;

                        if (count >= secondPart)
                        {
                            validWords.Add(word.Value);
                        }



                    }
                }

                    inputLine = Console.ReadLine();
                }

                Console.WriteLine(string.Join(", ", validWords));
            }
        }
    }

