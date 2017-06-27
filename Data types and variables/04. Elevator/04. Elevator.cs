

namespace _04.Elevator
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)peopleNumber / capacity);
            Console.WriteLine(courses);
        }
    }
}
