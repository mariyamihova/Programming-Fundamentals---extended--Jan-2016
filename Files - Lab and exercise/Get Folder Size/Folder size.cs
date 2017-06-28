

namespace Get_Folder_Size
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    class Program
    {
        static void Main()
        {
            var currentFiles = Directory
                .GetFiles("TestFolder");
            var totalLength = 0L;

            foreach (var file in currentFiles)
            {
                var fileInfo = new FileInfo(file);
                totalLength += fileInfo.Length;
            }
            double result = totalLength / 1024.0 / 1024;
            File.WriteAllText("output.txt", result.ToString());
        }
    }
}
