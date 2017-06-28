

namespace Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using System.IO;

    class Program
    {
        static void Main()
        {
            var words = File.ReadAllText("words.txt").Split(new[] { ' ', '\n','\r' },StringSplitOptions.RemoveEmptyEntries)
                .Select(w=>w.ToLower()).ToArray();

            var textWords = File.ReadAllText("input.txt").Split(new[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' })
                .Select(t => t.ToLower()).ToArray();

                var result = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var count = 0;
                for (int j = 0; j < textWords.Length; j++)
                {
                    if (currentWord==textWords[j])
                    {
                        count++;
                    }
                }
                result[currentWord] = count;
            }
            var sortedResult = result.OrderByDescending(kvp => kvp.Value).Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray();
            File.WriteAllLines("output.txt", sortedResult);
        }
    }
}
