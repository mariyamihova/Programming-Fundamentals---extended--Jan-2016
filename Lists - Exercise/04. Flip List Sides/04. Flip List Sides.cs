
namespace _04.Flip_List_Sides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] reversedNumbers = new int[numbers.Length];
            if (numbers.Length % 2 == 0)
            {
                reversedNumbers[0] = numbers[0];
                reversedNumbers[numbers.Length - 1] = numbers[numbers.Length - 1];
                for (int i = 1; i < reversedNumbers.Length - 1; i++)
                {
                    reversedNumbers[i] = numbers[numbers.Length - 1 - i];
                }
                Console.WriteLine(string.Join(" ", reversedNumbers));
            }
            else
            {
                reversedNumbers[0] = numbers[0];
                reversedNumbers[reversedNumbers.Length / 2] = numbers[numbers.Length / 2];
                reversedNumbers[numbers.Length - 1] = numbers[numbers.Length - 1];
                for (int i = 1; i < reversedNumbers.Length / 2; i++)
                {
                    reversedNumbers[i] = numbers[numbers.Length - 1 - i];
                }
                for (int i = reversedNumbers.Length / 2 + 1; i < reversedNumbers.Length - 1; i++)
                {
                    reversedNumbers[i] = numbers[numbers.Length - 1 - i];
                }

                Console.WriteLine(string.Join(" ", reversedNumbers));
            }

        }
    }
}
