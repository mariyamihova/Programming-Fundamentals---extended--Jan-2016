
namespace _06.Math_Power
{
    using System;
    class Program
    {
        static void Main()
        {

            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseNumber(number, power));

        }
        public static double RaiseNumber(double number, double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
