

namespace _05.Integer_to_Base
{
    using System;
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            string numberToBase = IntegerToBase(number, toBase);
            Console.WriteLine(numberToBase);

        }
        public static string IntegerToBase(long number, int toBase)
        {

            string result = string.Empty;
            do
            {
                result = number % toBase + result;
                number /= toBase;
            }
            while (number > 0);

            return result;
        }

    }
}
