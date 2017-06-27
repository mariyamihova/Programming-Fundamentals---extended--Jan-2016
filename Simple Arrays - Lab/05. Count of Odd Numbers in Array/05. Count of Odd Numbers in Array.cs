
namespace _05.Count_of_Odd_Numbers_in_Array
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int countOfOddNums = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % 2 == 1 || numbers[i] % 2 == -1)
                {
                    countOfOddNums++;
                }

            }
            Console.WriteLine(countOfOddNums);
        }
    }
}
