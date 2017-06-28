using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_and_LINQ__More_Exercises
{
    class Program
    {
        static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, string>>();

            var inputLine = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

            while (inputLine[0] != "lambada")
            {
                if (inputLine[0] != "dance")
                {
                    var selector = inputLine[0];
                    var secondPart = inputLine[1].Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
                    var selectorObject = secondPart[0];
                    var property = secondPart[1];
                    if (!result.ContainsKey(selector))
                    {
                        result.Add(selector, new Dictionary<string, string>());
                    }
                    result[selector][selectorObject] = property;

                }
                else
                {

                    result = result
                        .ToDictionary(selector => selector.Key, selector => selector.Value.ToDictionary(selectorObject => selectorObject.Key, selectorObject => selectorObject.Key + "." + selectorObject.Value));

                }
                inputLine = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var selector in result)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine($"{selector.Key} => {selectorObject.Key}.{selectorObject.Value}");
                }
            }
        }
    }
