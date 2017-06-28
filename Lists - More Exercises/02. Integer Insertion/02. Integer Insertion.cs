

namespace _02.Integer_Insertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                InsertNumber(numbers, input);
                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        public static void InsertNumber(List<int> numbers, string input)
        {
            int number = (int.Parse)(input);
            while (number > 10)
            {
                number /= 10;
            }
            int firstDigit = number;
            int numberTwo = (int.Parse)(input);
            numbers.Insert(firstDigit, numberTwo);
        }
    }
}
