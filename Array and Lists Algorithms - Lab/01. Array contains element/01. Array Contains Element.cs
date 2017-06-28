
namespace Array_and_Lists_Algorithms___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int number = int.Parse(Console.ReadLine());
            var found = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
