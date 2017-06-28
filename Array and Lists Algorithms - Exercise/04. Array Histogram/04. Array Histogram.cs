
namespace _04.Array_Histogram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split();

            List<string> words = new List<string>();
            List<int> occurence = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!words.Contains(text[i]))
                {
                    words.Add(text[i]);
                    occurence.Add(1);
                }
                else
                {
                    int index = words.FindIndex(x => x == text[i]);
                    int currentNum = occurence[index];
                    int number = currentNum + 1;
                    occurence[index] = number;
                }
            }
            bool unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (int i = 0; i < occurence.Count - 1; i++)
                {
                    if (occurence[i] < occurence[i + 1])
                    {
                        int temp = occurence[i];
                        occurence[i] = occurence[i + 1];
                        occurence[i + 1] = temp;

                        string tempString = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = tempString;

                        unsorted = true;
                    }
                }
            }
            for (int i = 0; i < words.Count; i++)
            {
                double percentage = (occurence[i] * 100.00 / text.Length);
                Console.WriteLine($"{words[i]} -> {occurence[i]} times ({percentage:f2}%)");
            }
        }
    }
}
