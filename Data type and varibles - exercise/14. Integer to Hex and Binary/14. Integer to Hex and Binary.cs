
namespace _14.Integer_to_Hex_and_Binary
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int decNumber = int.Parse(Console.ReadLine());

            string numberConverted = Convert.ToString(decNumber, 16);
            string numberConverted2 = Convert.ToString(decNumber, 2);
            string string1 = numberConverted.ToUpper();
            string string2 = numberConverted2.ToUpper();
            Console.WriteLine(string1);
            Console.WriteLine(string2);
        }
    }
}
