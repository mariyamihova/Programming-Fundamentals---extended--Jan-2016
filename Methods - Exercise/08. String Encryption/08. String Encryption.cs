
namespace _08.String_Encryption
{
    using System;
    class Program
    {
        static void Main()

        {
            int number = int.Parse(Console.ReadLine());

            var result = String.Empty;
            for (int i = 0; i < number; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                string encrypted = Encrypt(letter);
                result += encrypted;
            }
            Console.WriteLine(result);

        }
        public static string Encrypt(char letter)
        {
            int asciiCode = (int)letter;
            int lastDigit = GetLastDigit(asciiCode);
            var firstPart = (char)(asciiCode + lastDigit);
            int firstDigit = GetFirstDigit(asciiCode);
            var secondPart = (char)(asciiCode - firstDigit);

            var result = $"{firstPart}{firstDigit}{lastDigit}{secondPart}";

            return result;
        }
        public static int GetFirstDigit(int asciiCode)
        {

            int firstDigit = asciiCode;
            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }
            return firstDigit;
        }
        public static int GetLastDigit(int asciiCode)
        {

            return asciiCode % 10;
        }
    }
}

