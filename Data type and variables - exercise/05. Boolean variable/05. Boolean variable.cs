
namespace _05.Boolean_variable
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool textConverted = Convert.ToBoolean(text);
            if (text == "True")
            {
                Console.WriteLine("Yes");
            }
            else if (text == "False")
            {
                Console.WriteLine("No");
            }
        }
    }
}
