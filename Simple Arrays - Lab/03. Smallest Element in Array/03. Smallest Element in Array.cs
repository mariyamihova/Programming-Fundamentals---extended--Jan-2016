


namespace _03.Smallest_Element_in_Array
{
    using System;
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            int smallestElement = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
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
