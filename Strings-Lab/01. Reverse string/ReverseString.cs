using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Lab
{
    class ReverseString
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            //string reversedInput = new string(inputLine.Reverse().ToArray());
            //Console.WriteLine(reversedInput);
            string reversed = "";

            for (int i = inputLine.Length - 1; i >= 0; i--)
            {
                reversed += inputLine[i];
            }
            Console.WriteLine(reversed);
        }
    }
}
