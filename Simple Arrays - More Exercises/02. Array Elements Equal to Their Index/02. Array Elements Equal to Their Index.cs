

namespace _02.Array_Elements_Equal_to_Their_Index
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string equalNumbers = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == i)
                {
                    equalNumbers += numbers[i] + " ";
                }
            }
            Console.WriteLine(equalNumbers);
        }
    }
}
