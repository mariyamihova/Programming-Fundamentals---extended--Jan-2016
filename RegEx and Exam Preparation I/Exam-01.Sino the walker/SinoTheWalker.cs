using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exam_01.Sino_the_walker
{
    class SinoTheWalker
    {
        static void Main()
        {
            var left = Console.ReadLine();
            var timeLeft = DateTime.ParseExact(left,"HH:mm:ss",CultureInfo.InvariantCulture);
            var stepsNumber = int.Parse(Console.ReadLine()) % 86400;
            var seconds= int.Parse(Console.ReadLine()) % 86400;

            var timeSpan = TimeSpan.FromSeconds(stepsNumber * seconds);
            var result = timeLeft.Add(timeSpan);
            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);
        }
    }
}
