


namespace _04.Count_Occurrences_of_Larger_Numbers_in_Array
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > p)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
