
namespace _04.Nth_Digit
{
    using System;
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            string numberIndex = IntegerToBase(number, index);
            Console.WriteLine(numberIndex);

        }
        public static string IntegerToBase(long number, int index)
        {

            string result = string.Empty;
            while (index-- > 1)
            {

                number /= 10;

            }
            int lastDigit = (int)number % 10;
            result = lastDigit.ToString();

            return result;
        }

    }
}
