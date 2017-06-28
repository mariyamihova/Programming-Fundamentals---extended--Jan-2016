
namespace _05.Tear_List_in_Half
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> initialList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> rightHalf = new List<int>();
            List<int> leftHalf = new List<int>();
            for (int i = 0; i < initialList.Count / 2; i++)
            {
                leftHalf.Add(initialList[i]);
            }
            for (int i = initialList.Count / 2; i < initialList.Count; i++)
            {
                rightHalf.Add(initialList[i]);
            }

            List<int> result = new List<int>();
            for (int i = 0; i < leftHalf.Count; i++)
            {
                result.Add(rightHalf[i] / 10);
                result.Add(leftHalf[i]);
                result.Add(rightHalf[i] % 10);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
