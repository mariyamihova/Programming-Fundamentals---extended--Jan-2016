
namespace Merge_Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    class Program
    {
        static void Main()
        {
            var infoFirst = File.ReadAllLines("firstfile.txt").ToList();
            var infoSecond= File.ReadAllLines("secondfile.txt").ToList();

            infoFirst.AddRange(infoSecond);
            infoFirst.Sort();
            File.WriteAllLines("result.txt", infoFirst);
        }
    }
}
