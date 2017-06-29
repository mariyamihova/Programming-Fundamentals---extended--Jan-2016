using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_V01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distance=double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var metersTravelled = (double)(wingFlaps / 1000) * distance;
            var seconds = (wingFlaps / 100) + ((wingFlaps / endurance) * 5);
            Console.WriteLine($"{metersTravelled:f2} m.");
            Console.WriteLine($"{seconds} s.");
        }
    }
}
