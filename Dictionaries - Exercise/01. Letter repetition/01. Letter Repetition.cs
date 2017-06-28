

namespace Dictionaries_Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var repetitions = new Dictionary<char, int>();
            foreach (char letter in input)
            {
                if (repetitions.ContainsKey(letter))
                {
                    repetitions[letter]++;
                }
                else
                {
                    repetitions[letter] = 1;
                }
            }
            foreach (var letter in repetitions.Keys)
            {
                Console.WriteLine($"{letter} -> {repetitions[letter]}");
            }
        }
    }
}
