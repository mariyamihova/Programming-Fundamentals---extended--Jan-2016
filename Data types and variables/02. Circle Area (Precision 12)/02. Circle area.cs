

namespace _02.Circle_Area__Precision_12_
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", Math.PI * radius * radius);
        }
    }
}
