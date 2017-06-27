
namespace Simple_Arrays_Lab
{
    using System;
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] ArrayOfNumbers = new int[numbers];
            int sum = 0;
            for (int i = 0; i < ArrayOfNumbers.Length; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                ArrayOfNumbers[i] = currentNumber;
                sum += ArrayOfNumbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
