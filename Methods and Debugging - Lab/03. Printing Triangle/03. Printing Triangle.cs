
namespace _03.Printing_Triangle
{
    using System;
    class Program
    {
        static void Main()
        {
            {
                int number = int.Parse(Console.ReadLine());
                PrintUpperpart(number);
                PrintLowpart(number);
            }

        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void PrintUpperpart(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintLine(1, i);
            }
        }
        public static void PrintLowpart(int number)
        {
            for (int i = number - 1; i >= 1; i--)
            {
                PrintLine(1, i);

            }
        }
    }
}
