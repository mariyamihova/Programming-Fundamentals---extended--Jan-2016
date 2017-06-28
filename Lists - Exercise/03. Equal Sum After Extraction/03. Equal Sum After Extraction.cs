
namespace _03.Equal_Sum_After_Extraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {

            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Contains(firstList[i]))
                {
                    secondList.Remove(firstList[i]);
                }
            }
            int sumSecond = secondList.Sum();
            int sumFirst = firstList.Sum();
            int diff = Math.Abs(sumFirst - sumSecond);
            if (sumFirst == sumSecond)
            {
                Console.WriteLine($"Yes. Sum: {sumSecond}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {diff}");
            }
    }
}
