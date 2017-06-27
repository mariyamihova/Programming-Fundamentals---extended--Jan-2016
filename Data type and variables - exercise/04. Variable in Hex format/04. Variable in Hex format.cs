
namespace _04.Variable_in_Hex_format
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int numberConverted = Convert.ToInt32(number, 16);
            Console.WriteLine(numberConverted);
        }
    }
}
