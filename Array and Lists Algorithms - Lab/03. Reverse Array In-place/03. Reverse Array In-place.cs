
namespace _03.Reverse_Array_In_place
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                var temp = numbers[i];
                numbers[i] = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = temp;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
