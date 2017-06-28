
namespace _06.Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            double[] capacity = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var hours = double.Parse(Console.ReadLine());

            for (int i = 0; i < capacity.Length; i++)
            {
                var remainingPower = capacity[i] - (usagePerHour[i] * hours);

                if (remainingPower > 0)
                {
                    var percentage = remainingPower * 100.00 / capacity[i];
                    Console.WriteLine($"Battery {i + 1}: {remainingPower:F2} mAh ({percentage:F2})%");
                }
                else
                {
                    int lasted = (int)Math.Ceiling(capacity[i] / usagePerHour[i]);
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {lasted} hours)");
                }
            }
        }
    }
}
