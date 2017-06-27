using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Numbers_to_Words
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            string numbersToWords = string.Empty;
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int digits = CountOfDigits(number);
                if (digits < 3)
                {
                    numbersToWords = string.Empty;
                    Console.WriteLine(numbersToWords);
                }
                else
                {
                    numbersToWords = NumberToWords(number);
                    Console.WriteLine(numbersToWords);
                }
            }

        }
        public static int CountOfDigits(int number)
        {
            number = Math.Abs(number);
            int countOfDigits = 1;
            while ((number /= 10) >= 1)
                countOfDigits++;
            return countOfDigits;

        }
        public static string NumberToWords(int number)

        {

            if (number > 999)
            {
                return "too large";
            }
            if (number < -999)
            {
                return "too small";
            }

            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + "-hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
