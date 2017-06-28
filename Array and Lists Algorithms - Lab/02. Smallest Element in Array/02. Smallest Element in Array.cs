
namespace _02.Smallest_Element_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int smallestElement = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < smallestElement)
                {
                    smallestElement = numbers[i];
                }
            }
            Console.WriteLine(smallestElement);
        }
    }
}
