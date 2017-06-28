
namespace _02.Randomize_Words
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ');
            var random = new Random();


            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomIndex = random.Next(0, words.Length);

                var temp = words[randomIndex];
                words[i] = temp;
                words[randomIndex] = currentWord;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
