
namespace _15.Fast_Prime_Checker
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 2; number <= n; number++)
            {
                bool check = true;
                for (int number2 = 2; number2 <= Math.Sqrt(number); number2++)
                {
                    if (number % number2 == 0)
                    {
                        check = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {check}");
            }
        }
    }
}
