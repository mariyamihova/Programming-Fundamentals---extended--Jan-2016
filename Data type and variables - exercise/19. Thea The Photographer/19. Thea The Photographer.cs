

namespace _19.Thea_The_Photographer
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long picturesCount = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filetrPercentage = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());


            long goodPics = (long)Math.Ceiling(picturesCount * ((double)filetrPercentage / 100));
            long filterseconds = picturesCount * filterTime;
            long uploadseconds = goodPics * uploadTime;

            long totalSeconds = filterseconds + uploadseconds;
            TimeSpan projectTime = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                projectTime.Days,
                projectTime.Hours,
                projectTime.Minutes,
                projectTime.Seconds);
        }
    }
}
