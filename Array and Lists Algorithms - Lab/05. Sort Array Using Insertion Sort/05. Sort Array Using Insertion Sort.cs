
namespace _05.Sort_Array_Using_Insertion_Sort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int firstUnsort = 0; firstUnsort < numbers.Length - 1; firstUnsort++)
            {
                var i = firstUnsort + 1;
                while (i > 0)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        var temp = numbers[i - 1];
                        numbers[i - 1] = numbers[i];
                        numbers[i] = temp;


                    }
                    i--;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
