

namespace Filter_Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
           var files = Directory.GetFiles("input");
            var result = new List<FileInfo>();
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                
                if(fileInfo.Extension=="."+inputLine)
                {
                    result.Add(fileInfo);
                }
                //var splitted = file.Split('.').Reverse().ToArray();
                //if (splitted[0]==inputLine)
                //{
                //    result.Add(file);
                //}
            }
            foreach (var element in result)
            {
                //var fileinfo = new FileInfo(element);
                Console.WriteLine(element.Name);
            }
        }
    }
}
