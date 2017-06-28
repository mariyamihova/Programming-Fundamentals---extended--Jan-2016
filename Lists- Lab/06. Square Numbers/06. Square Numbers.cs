
namespace _06.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            numbers.Reverse();
            List<int> squareNumbers = new List<int>();

            foreach (int num in numbers)
            {
                var square = Math.Sqrt(num);
                if (square == (int)square)
                {
                    squareNumbers.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", squareNumbers));

        }
    }
}
