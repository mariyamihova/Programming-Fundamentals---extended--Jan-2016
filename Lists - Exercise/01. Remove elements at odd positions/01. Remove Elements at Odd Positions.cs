

namespace Lists___Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();
            for (int i = 1; i < words.Count; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(words[i]);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
