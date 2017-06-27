
namespace _06.Tripples_of_letters
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int first = 0; first < n; first++)
                for (int second = 0; second < n; second++)
                    for (int third = 0; third < n; third++)
                    {
                        char letterFirst = (char)('a' + first);
                        char letterSecond = (char)('a' + second);
                        char letterThird = (char)('a' + third);
                        Console.WriteLine("{0}{1}{2}", letterFirst, letterSecond, letterThird);

                    }
        }
    }
}
