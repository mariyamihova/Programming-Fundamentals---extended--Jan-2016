

namespace _05.Decode_Radio_Frequencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            List<char> result = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                string[] frequence = new string[2];
                frequence = input[i].Split('.');
                int leftPart = int.Parse(frequence[0]);
                int rightPart = int.Parse(frequence[1]);
                char leftChar = (char)(leftPart);
                char rightChar = (char)(rightPart);
                if (leftPart != 0)
                {
                    result.Insert(i, leftChar);
                }
                if (rightPart != 0)
                {
                    result.Insert(result.Count - i, rightChar);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
