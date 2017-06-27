

namespace _04.Rotate_Array_of_Strings
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split();



            string[] result = new string[text.Length];
            result[0] = text[text.Length - 1];
            for (int i = 0; i < text.Length - 1; i++)
            {

                result[i + 1] = text[i];
            }
            var resultAsString = string.Join(" ", result);
            Console.WriteLine(resultAsString);
        }
    }
}
