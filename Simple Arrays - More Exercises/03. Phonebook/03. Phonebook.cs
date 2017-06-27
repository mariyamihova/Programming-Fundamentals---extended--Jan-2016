
namespace _03.Phonebook
{
    using System;
    class Program
    {
        static void Main()
        {
            string[] phonenumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();

            string inputLine = Console.ReadLine();
            while (inputLine != "done")
            {
                PrintElement(names, phonenumbers, inputLine);
                inputLine = Console.ReadLine();
            }
        }

        private static void PrintElement(string[] names, string[] phonenumbers, string inputLine)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == inputLine)
                {
                    Console.WriteLine($"{names[i]} -> {phonenumbers[i]}");
                }
            }
        }
    }
}
