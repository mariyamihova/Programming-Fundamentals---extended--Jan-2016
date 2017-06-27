
namespace _07.Greater_of_Two_Values
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            public static void Main()
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstNumber, secondNumber));

            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstChar, secondChar));
            }
            else
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                Console.WriteLine(GetMax(firstString, secondString));
            }
        }
        public static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        public static char GetMax(char firstChar, char secondChar)
        {
            if ((int)firstChar >= (int)secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }

        }
        public static string GetMax(string firstString, string secondString)

        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }

        }
    }
}
    
