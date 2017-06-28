
namespace Files_Lab
{
    using System;
    using System.Collections.Generic;
    using System.IO

    class Program
    {
        static void Main()
        {
            var file = "inputfile.txt";
            var lines = File.ReadAllLines(file);

            var oddLines = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (i%2!=0)
                {
                    oddLines.Add(lines[i]);
                }
            }
            File.WriteAllLines("result.txt", oddLines);
        }
    }
}
