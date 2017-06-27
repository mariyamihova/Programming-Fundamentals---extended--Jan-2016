
namespace _08.Debugging__Multiply_Evens_by_Odds
{
    using System;
    class Program
    {
        public static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetSumofEvenAndOdds(number));
        }
        public static int GetSumofEvenAndOdds(int number)
        {
            int sumEvens = (GetSumOfEvenDigits(number));
            int sumOdds = (GetSumOfOddDigits(number));
            return sumEvens * sumOdds;
        }
        public static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastdigit = number % 10;
                if (lastdigit % 2 != 0)
                {
                    sum += lastdigit;
                }
                number /= 10;
            }
            return sum;
        }
        public static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastdigit = number % 10;
                if (lastdigit % 2 == 0)
                {
                    sum += lastdigit;
                }
                number /= 10;
            }
            return sum;

        }
    }
}
