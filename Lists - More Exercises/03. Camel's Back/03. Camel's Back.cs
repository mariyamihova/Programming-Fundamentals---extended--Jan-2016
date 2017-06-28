
namespace _03.Camel_s_Back
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int camelBackSize = int.Parse(Console.ReadLine());
            int rounds = 0;

            while (numbers.Count > camelBackSize)
            {
                numbers.RemoveAt(0);
                numbers.RemoveAt(numbers.Count - 1);
                rounds++;
            }
            if (rounds == 0)
            {
                Console.WriteLine($"already stable: {string.Join(" ", numbers)}");
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", numbers)}");
            }
        }
    }
}
