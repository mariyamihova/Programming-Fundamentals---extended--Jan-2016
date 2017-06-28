
namespace _06.Insertion_Sort_Using_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> result = new List<int>();
            for (int arrIndex = 0; arrIndex < numbers.Length; arrIndex++)
            {
                var inserted = false;
                var currentElement = numbers[arrIndex];
                for (int listIndex = 0; listIndex < result.Count; listIndex++)
                {
                    var currentListElement = result[listIndex];
                    if (currentElement <= currentListElement)
                    {
                        inserted = true;
                        result.Insert(Math.Max(0, listIndex), currentElement);
                        break;
                    }
                }
                if (!inserted)
                {
                    result.Add(currentElement);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
