
namespace _03.String_Repeater
{
    using System;

    class Program
    {
        static void Main()
        {
            string toBePrinted = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(toBePrinted, count));

        }
        public static string RepeatString(string toBeprinted, int count)
        {
            string repeatedString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                repeatedString = repeatedString + toBeprinted;
            }
            return repeatedString;

        }

    }
}
