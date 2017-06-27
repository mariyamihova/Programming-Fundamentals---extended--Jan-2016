


namespace _07.Count_of_Capital_Letters_in_Array
{
    using System;
    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split();
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                string currentWord = text[i];

                if (currentWord.Length == 1)
                {
                    char character = currentWord[0];
                    if (character >= 65 && character <= 90)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
