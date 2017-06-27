
namespace _08.Array_Symmetry
{
    using System;
    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split();
            bool isSymetric = true;

            for (int i = 0; i < text.Length / 2; i++)
            {
                string firstWord = text[i];
                string secondWord = text[text.Length - 1 - i];
                if (firstWord != secondWord)
                {
                    isSymetric = false;
                    break;
                }

            }
            if (isSymetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
