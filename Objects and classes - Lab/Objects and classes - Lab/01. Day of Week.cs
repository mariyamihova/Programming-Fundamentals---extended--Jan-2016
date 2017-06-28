
namespace Objects_and_classes_Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
            var date = DateTime.ParseExact(inputLine, "d-M-yyyy", CultureInfo.InvariantCulture);
            var dayOfWeek = date.DayOfWeek;
            Console.WriteLine(dayOfWeek);
        }
    }
}
