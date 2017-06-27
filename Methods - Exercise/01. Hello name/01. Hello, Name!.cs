
namespace Methods___Exercise
{
    using System;
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }
        public static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
