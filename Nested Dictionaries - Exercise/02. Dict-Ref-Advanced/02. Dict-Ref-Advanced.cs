

namespace _02.Dict_Ref_Advanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var result = new Dictionary<string, List<int>>();

            while (input[0] != "end")

            {
                var secondPart = input[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in secondPart)
                {
                    int number = 0;
                    bool isNumber = int.TryParse(element, out number);
                    if (isNumber)
                    {
                        if (!result.ContainsKey(input[0]))
                        {
                            result[input[0]] = new List<int>();
                        }
                        result[input[0]].Add(number);
                    }
                    else
                    {
                        string otherKey = element;
                        if (result.ContainsKey(otherKey))//element
                        {

                            result[input[0]] = new List<int>(result[otherKey]);
                        }
                    }
                }

                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }



            foreach (var nameAndvalues in result)
            {
                var name = nameAndvalues.Key;
                var values = nameAndvalues.Value;

                Console.WriteLine($"{name} === {string.Join(", ", values)}");
            }


        }
    }
}
