

namespace _04.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            var firstRowLeft = numbers.Take(k).Reverse().ToArray();
            var firstRowRight = numbers.Reverse().Take(k).ToArray();
            var firstRow = firstRowLeft.Concat(firstRowRight).ToArray();
            var secondRow = numbers.Skip(k).Take(k * 2).ToArray();

            var sum = new int[firstRow.Length];
            for (int i = 0; i < firstRow.Length; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
