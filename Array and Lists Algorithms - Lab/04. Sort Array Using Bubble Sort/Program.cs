
namespace _04.Sort_Array_Using_Bubble_Sort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
            while (swapped);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
