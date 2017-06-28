
namespace _02.Track_Downloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var blackList = Console.ReadLine().Split(' ');
            var line = Console.ReadLine();
            var newList = new List<string>();

            while (line != "end")
            {
                var isOnBlackList = false;
                foreach (var word in blackList)
                {
                    if (line.Contains(word))
                    {
                        isOnBlackList = true;
                        break;
                    }
                }
                if (!isOnBlackList)
                {
                    newList.Add(line);
                }

                line = Console.ReadLine();

            }
            newList.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, newList));

        }
    }
}
