


namespace _05.Char_Rotation
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string symbols = Console.ReadLine();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var chars = symbols.ToCharArray();
            char[] result = new char[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result[i] = (char)(Math.Abs(numbers[i] - (int)chars[i]));
                }
                else
                {
                    result[i] = (char)(numbers[i] + (int)chars[i]);
                }
            }

            Console.WriteLine(string.Join("", result));

        }
    }
}
