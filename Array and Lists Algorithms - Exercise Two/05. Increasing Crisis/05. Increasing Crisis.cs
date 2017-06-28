
namespace _05.Increasing_Crisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            var result = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < count - 1; i++)
            {
                var toBeAdded = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                toBeAdded.Add(int.MaxValue);
                var newList = new List<int>();
                for (int j = 1; j < toBeAdded.Count; j++)
                {
                    if (toBeAdded[j] >= toBeAdded[j - 1])
                    {
                        newList.Add(toBeAdded[j - 1]);
                    }
                    else
                    {
                        newList.Add(toBeAdded[j - 1]);
                        break;
                    }
                }
                int lowerByValue = 0;
                for (int k = 0; k < result.Count; k++)
                {
                    if (newList[0] >= result[k])
                    {
                        lowerByValue = result[k];

                    }
                    else
                    {
                        break;
                    }
                }
                if (newList.Count > 1)
                {
                    int index = result.IndexOf(lowerByValue);
                    result.InsertRange(index + 1, newList);
                }
                else
                {

                    int index = result.IndexOf(lowerByValue);
                    result.InsertRange(index + 1, newList);
                    result.RemoveRange(index + 2, result.Count - (index + 2));
                }
            }




            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
   