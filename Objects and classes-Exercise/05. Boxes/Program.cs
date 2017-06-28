using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static double CalculateDistance(Point point1, Point point2)
        {
            double sideA = point1.X - point2.X;
            double sideB = point1.Y - point2.Y;

            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }
    }
    class Box

    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }
        public double Width
        {
            get
            {
                return Point.CalculateDistance(UpperLeft, UpperRight);
            }
        }
        public double Height
        {
            get
            {
                return Point.CalculateDistance(UpperLeft,BottomLeft);
            }
        }
        public static int CalculatePerimeter(int width, int height)
        {
            return 2 * width + 2 * height;
        }
        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }

    }
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
            var rectangles = new List<Point>();
            var result = new List<Box>();
            while (inputLine!="end")

            {
                var splittedInput = inputLine.Split(new[] { ' ', '|', ':' }, StringSplitOptions.RemoveEmptyEntries);
                var UpperLeftPoint = new Point
                {
                    X = int.Parse(splittedInput[0]),
                    Y = int.Parse(splittedInput[1])
                };
                
                var UpperRightPoint = new Point
                {
                    X = int.Parse(splittedInput[2]),
                    Y = int.Parse(splittedInput[3])
                };
                
                var BottomLeftPoint = new Point
                {
                    X = int.Parse(splittedInput[4]),
                    Y = int.Parse(splittedInput[5])
                };
                
                var BottomRightPoint = new Point
                {
                    X = int.Parse(splittedInput[6]),
                    Y = int.Parse(splittedInput[7])
                };
               

                var newObject = new Box
                {
                    UpperLeft = UpperLeftPoint,
                    UpperRight = UpperRightPoint,
                    BottomLeft = BottomLeftPoint,
                    BottomRight = BottomRightPoint
                };
                result.Add(newObject);
                inputLine = Console.ReadLine();
            }
            foreach (var element in result)
            {
                int width = (int)(element.Width);
                int height = (int)(element.Height);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter(width, height)}");
                Console.WriteLine($"Area: {Box.CalculateArea(width, height)}");
            }
        }
    }
}
