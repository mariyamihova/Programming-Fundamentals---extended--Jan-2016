
namespace _06.Stuck_Zipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var idealNumberOfDigits = CalculateIdealNumberOfDigits(firstList, secondList);

            RemoveElements(firstList, idealNumberOfDigits);
            RemoveElements(secondList, idealNumberOfDigits);
            var index = 1;
            for (int i = 0; i < firstList.Count; i++)
            {
                secondList.Insert(Math.Min(index, secondList.Count), firstList[i]);
                index += 2;
            }
            Console.WriteLine(string.Join(" ", secondList));

        }

        public static void RemoveElements(List<int> list, int idealNumberOfDigits)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var currentNumberOfDigits = CalculateNumberOfDigits(list[i]);
                if (currentNumberOfDigits > idealNumberOfDigits)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }

        }

        public static int CalculateIdealNumberOfDigits(List<int> firstList, List<int> secondList)
        {
            var idealNumberOfDigits = int.MaxValue;
            foreach (var item in firstList)
            {
                var numberOfDigits = CalculateNumberOfDigits(item);
                if (numberOfDigits < idealNumberOfDigits)
                {
                    idealNumberOfDigits = numberOfDigits;
                }
            }
            foreach (var item in secondList)
            {
                var numberOfDigits = CalculateNumberOfDigits(item);
                if (numberOfDigits < idealNumberOfDigits)
                {
                    idealNumberOfDigits = numberOfDigits;
                }
            }

            return idealNumberOfDigits;
        }

        public static int CalculateNumberOfDigits(int number)
        {
            number = Math.Abs(number);
            var numberOfDigits = 0;
            while (number > 0)
            {
                numberOfDigits++;
                number /= 10;
            }
            return numberOfDigits;
        }
    }
}







