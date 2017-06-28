
namespace _03.Mixed_Phones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var result = new SortedDictionary<string, long>();

            while (input[0] != "Over")
            {
                long number = 0;
                bool isNumber = long.TryParse(input[0], out number);
                if (isNumber)
                {
                    if (!result.ContainsKey(input[2]))
                    {
                        result[input[2]] = number;
                    }
                }
                else
                {
                    long secondNumber = long.Parse(input[2]);
                    if (!result.ContainsKey(input[0]))
                    {
                        result[input[0]] = secondNumber;
                    }
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
            foreach (var name in result.Keys)
            {
                Console.WriteLine($"{name} -> {result[name]}");
            }

        }
    }
}
