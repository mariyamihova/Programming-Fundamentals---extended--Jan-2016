
namespace _12.Rectangle_Properties
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            double diagonalpersq = width * width + height * height;
            double diagonal = Math.Sqrt(diagonalpersq);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
