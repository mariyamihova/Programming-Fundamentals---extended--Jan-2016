
namespace _05.Calculate_Triangle_Area
{
    using System;
    class Program
    {
        static void Main()
        {

            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateTriangleArea(a, ha));

        }
        public static double CalculateTriangleArea(double a, double ha)
        {
            return a * ha / 2;
        }
    }
}
