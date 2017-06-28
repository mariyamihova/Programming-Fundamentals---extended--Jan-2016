

namespace _03.Sort_Array_of_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split().ToArray();
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < words.Length - 1; i++)
                {
                    var firstWord = words[i];
                    var secondWord = words[i + 1];
                    if (firstWord.CompareTo(secondWord) == 1)
                    {
                        var temp = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = temp;
                        swapped = true;
                    }
                }

            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
