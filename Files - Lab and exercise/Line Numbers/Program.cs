

namespace Line_Numbers
{
    using System;
    using System.Collections.Generic;
  
    using System.IO;
    class Program
    {
        static void Main()
        {
            var file = "inputfile.txt";
            var lines = File.ReadAllLines(file);

            var result = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                result.Add($"{i + 1}. {lines[i]}");
            }
            File.WriteAllLines("result.txt", result);

        }
    }
}
