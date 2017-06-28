

namespace _02.Average_Character_Delimiter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split();

            int firstSum = 0;
            int secondSum = 0;
            int lenghtFirst = 0;
            int lenghtSec = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length > 1)
                {
                    foreach (char letter in text[i])
                    {
                        int asciiCodeLetter = (int)(letter);
                        secondSum += asciiCodeLetter;
                        lenghtSec++;
                    }
                }
                else
                {
                    foreach (char c in text[i])
                    {
                        int code = (int)(c);
                        firstSum += code;
                        lenghtFirst++;
                    }

                }
            }
            double totalSum = firstSum + secondSum;
            double totalLength = lenghtFirst + lenghtSec;
            double letterDelimiter = Math.Floor(totalSum / totalLength);
            char delimiter = (char)(letterDelimiter);
            char newDelimiter = char.ToUpper(delimiter);

            List<string> textSecond = new List<string>();
            for (int i = 0; i < text.Length - 1; i++)
            {
                string element = text[i] + newDelimiter;
                textSecond.Add(element);
            }
            textSecond.Add(text[text.Length - 1]);
            Console.WriteLine(string.Join("", textSecond));

        }
    }
    }

