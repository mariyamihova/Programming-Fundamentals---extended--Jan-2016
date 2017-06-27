
namespace _02.Min_Method
{
    using System;
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int smallestNumber = Math.Min(GetMin(firstNumber, secondNumber), thirdNumber);

            Console.WriteLine($"{smallestNumber}");
        }
        public static int GetMin(int firstNumber, int secondNumber)
        {
            int smallerNumber = Math.Min(firstNumber, secondNumber);
            return smallerNumber;
        }
    }
}
