using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var regex = new Regex(@"^[A-Z].*[.?!]$");
            var regexWord = new Regex(@"\b\w+\b");
            var result = new Dictionary<char, int>();
            var newSentence = string.Empty;
            while (inputLine!= "Worm Ipsum")
            {
                if (regex.IsMatch(inputLine))
                {
                    var sentence = regex.Match(inputLine);
                    var splittedSentence = sentence.ToString().Split(new[] { ". " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (splittedSentence.Length!=1)
                    {
                        inputLine = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        var initialSentence = sentence.ToString();
                        var letter = ' ';
                        var matches = regexWord.Matches(sentence.ToString());
                        foreach (Match match in matches)
                        {
                            result.Clear();
                            var word = match.Value.ToString();
                           
                            foreach (char symbol in word)
                            {
                                if (!result.ContainsKey(symbol))
                                {
                                    result[symbol] = 0;
                                }
                                result[symbol]++;
                            }
                            var orderedResult = result.Where(x => x.Value >= 2).ToDictionary(x => x.Key, x => x.Value);
                            if (orderedResult.Count!=0)
                            {
                                var replacement = orderedResult.OrderByDescending(x=>x.Value).
                                    Take(1).ToDictionary(y => y.Key, y => y.Value);
                                foreach (var pair in replacement)
                                {
                                    letter = pair.Key;
                                }
                                newSentence = initialSentence.ToString().Replace(word, new string(letter, word.Length));
                                initialSentence = newSentence;
                                
                            }
                            else
                            {
                                newSentence = initialSentence;
                            }
                           
                            
                        }

                        Console.WriteLine($"{newSentence}");

                        

                    }

                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
