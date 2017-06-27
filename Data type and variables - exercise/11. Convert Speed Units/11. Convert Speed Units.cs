
namespace _11.Convert_Speed_Units
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int distanceinM = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double seconds2 = (hours * 60) * 60 + minutes * 60 + seconds;
            double hours2 = hours + minutes / 60.00 + (seconds / 60.00) / 60.00;
            double distanceinkm = distanceinM / 1000.00;
            double distanceinMiles = distanceinM / 1609.00;
            double speedMS = distanceinM / seconds2;
            double speedKMH = distanceinkm / hours2;
            double speedMPH = distanceinMiles / hours2;
            Console.WriteLine("{0:f6}", speedMS);
            Console.WriteLine("{0:f6}", speedKMH);
            Console.WriteLine("{0:f6}", speedMPH);
        }
    }
}
