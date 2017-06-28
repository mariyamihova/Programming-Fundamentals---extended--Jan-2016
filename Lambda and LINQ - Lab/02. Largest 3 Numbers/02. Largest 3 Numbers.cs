
namespace _02.Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            if (numbers.Count >= 3)
            {
                var result = numbers.OrderByDescending(x => x).Take(3);
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                numbers.Sort();
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
