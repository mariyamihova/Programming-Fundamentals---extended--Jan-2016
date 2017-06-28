

namespace _04.Distance_between_Points
{
    using System;
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            var firstPoint = Console.ReadLine().Split();
            var secondPoint = Console.ReadLine().Split();
            var first = new Point
            {
                X = double.Parse(firstPoint[0]),
                Y = double.Parse(firstPoint[1])

            };
            var second = new Point
            {
                X = double.Parse(secondPoint[0]),
                Y = double.Parse(secondPoint[1])

            };
            var result = CalculateDistance(first, second);
            Console.WriteLine($"{result:f3}");

        }
        public static double CalculateDistance(Point first, Point second)
        {
            var diffX = first.X - second.X;
            var diffY = first.Y - second.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
       
    }
}


