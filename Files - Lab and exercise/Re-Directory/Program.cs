

namespace Re_Directory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    class Program
    {
        static void Main()
        {
            var inputContent = Directory.GetFiles("input");
            Directory.CreateDirectory("output");
            Directory.CreateDirectory("output/pngs");
            Directory.CreateDirectory("output/tests");
            Directory.CreateDirectory("output/txts");
           
            foreach (var file in inputContent)
            {
                var extension = Path.GetExtension(file);
                //var fileInfo = new FileInfo(file);

                if (extension == ".png")
                {

                   var fileName = Path.GetFileName(file);
                    var targetFolder = "output/pngs";
                   var destFile = Path.Combine(targetFolder, fileName);
                  File.Copy(file, destFile, true);

                }
                else if (extension==".test")
                {
                    var fileName = Path.GetFileName(file);
                    var targetFolder = "output/tests";
                    var destFile = Path.Combine(targetFolder, fileName);
                    File.Copy(file, destFile, true);

                }
                else if (extension== ".txt")
                {
                    var fileName = Path.GetFileName(file);
                    var targetFolder = "output/txts";
                    var destFile = Path.Combine(targetFolder, fileName);
                    File.Copy(file, destFile, true);
                }
            }
            
        }
        }
}
