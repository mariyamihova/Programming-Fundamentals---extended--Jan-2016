using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalize_Words_Third_edition
{
    class Program
    {
            static void Main(string[] args)
            {
                string input = Console.ReadLine().ToLower();
                var newWords = new List<string>();

                while (input != "end")
                {
                    var inputLine = input
                        .Split(new char[] { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\', '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#', '\"', '!' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in inputLine)
                    {
                        var resultWord = char.ToUpper(word[0]) + word.Substring(1);
                    newWords.Add(resultWord);
                    }

                    Console.WriteLine(string.Join(", ", newWords));

                    newWords.Clear();

                    input = Console.ReadLine().ToLower();
                }
            }

           
        }
    }




