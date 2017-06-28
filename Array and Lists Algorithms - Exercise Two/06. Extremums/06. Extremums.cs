
namespace _06.Extremums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = RotateDigits(numbers[i], command);
            }
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(numbers.Sum());

        }

        public static int RotateDigits(int number, string command)
        {
            List<int> newNumbers = new List<int>();
            string numberToString = number.ToString();
            foreach (var digit in numberToString)
            {
                newNumbers.Add(int.Parse(digit.ToString()));
            }
            for (int i = 0; i < newNumbers.Count; i++)
            {
                var firstDigit = newNumbers[0];
                for (int j = 0; j < newNumbers.Count - 1; j++)
                {
                    newNumbers[j] = newNumbers[j + 1];
                }
                newNumbers[newNumbers.Count - 1] = firstDigit;
                var currentNumber = int.Parse(string.Join("", newNumbers));
                if (currentNumber > number && command == "Max")
                {
                    number = currentNumber;
                }
                else if (currentNumber < number && command == "Min")
                {
                    number = currentNumber;
                }
            }
            return number;
        }
    }
}
