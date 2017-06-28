
namespace _02.Dict_Ref
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var result = new Dictionary<string, int>();

            while (input[0] != "end")
            {
                int number = 0;
                bool isNumber = int.TryParse(input[2], out number);
                if (isNumber)
                {
                    if (!result.ContainsKey(input[0]))
                    {

                        result.Add(input[0], number);
                    }
                    else
                    {
                        int secondValue = number;
                        result[input[0]] = secondValue;
                    }
                }
                else
                {
                    if (result.ContainsKey(input[2]))
                    {
                        int value = 0;
                        bool exists = result.TryGetValue(input[2], out value);
                        result[input[0]] = value;
                    }
                }
                input = Console.ReadLine().Split().ToArray();
            }
            foreach (var name in result.Keys)
            {
                Console.WriteLine($"{name} === {result[name]}");
            }

        }
    }
}
