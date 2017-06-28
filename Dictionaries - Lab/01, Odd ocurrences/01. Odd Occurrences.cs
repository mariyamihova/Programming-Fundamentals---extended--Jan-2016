
namespace Dictionaries_Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');
            var result = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
                else
                {
                    result[word] = 1;
                }
            }
            var results = new List<string>();
            foreach (var kvp in result)
            {
                if (kvp.Value % 2 != 0)
                {
                    results.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
