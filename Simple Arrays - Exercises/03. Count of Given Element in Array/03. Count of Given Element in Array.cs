


namespace _03.Count_of_Given_Element_in_Array
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
