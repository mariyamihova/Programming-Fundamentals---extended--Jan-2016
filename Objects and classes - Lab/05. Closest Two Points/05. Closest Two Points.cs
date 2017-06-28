
namespace _05.Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public string Print()
        {
            return $"({X}, {Y})";
        }
    }

    class Program
    {
        
         static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            double minDistance = double.MaxValue;
            Point firstResult = null;
            Point secondResult = null;
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var distance = CalculateDistance(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstResult = points[i];
                        secondResult = points[j];
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine(firstResult.Print());
            Console.WriteLine(secondResult.Print());

        }

        public static Point ReadPoint()
        {
            var inputLine = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var point = new Point { X = inputLine[0], Y = inputLine[1] };
            return point;
        }

        public static double CalculateDistance(Point point1, Point point2)
        {
            double sideA = point1.X - point2.X;
            double sideB = point1.Y - point2.Y;

            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }
       
    }
}

