using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Exercise
{
    class Placeholders
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var splittedInput = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var placeholders = splittedInput[1].Trim().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var firstPart = splittedInput[0].Trim();
                var result = string.Empty;
                var currentText = firstPart;

                for (int i = 0; i < placeholders.Count; i++)
                {
                    string currentPlaceholder = "{" + i + "}";
                    firstPart = firstPart.Replace(currentPlaceholder, placeholders[i]);
                   
                }
               
                Console.WriteLine(firstPart);

                inputLine = Console.ReadLine();
            }

    }
    }
}
