


namespace _07.Exchange_variable_values
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before:");
            int a = 5;
            Console.WriteLine("a = {0}", a);
            int b = 10;
            Console.WriteLine("b = {0}", b);


            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }
}
