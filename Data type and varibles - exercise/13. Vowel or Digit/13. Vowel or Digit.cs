

namespace _13.Vowel_or_Digit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string symbol = (Console.ReadLine());
            int num = 0;
            if (int.TryParse(symbol, out num))
            {
                Console.WriteLine("digit");
            }
            else if (symbol == "a" || symbol == "e" || symbol == "i" || symbol == "o" || symbol == "u" || symbol == "Y")

            {
                Console.WriteLine("vowel");
            }
            else

            {
                Console.WriteLine("other");
            }
        }
    }
}
