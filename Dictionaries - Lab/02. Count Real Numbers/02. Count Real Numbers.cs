
namespace _02.Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var counts = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }

            }
            foreach (var num in counts.Keys)
            {

                Console.WriteLine($"{num} -> {counts[num]}");


            }
        }
    }
}
