using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Split
{
    class Program
    {
        static void Main()
        {
            var sentence = Console.ReadLine();
            var delimiter = Console.ReadLine();

            if (sentence.Contains(delimiter))
            {
               var newSentence= sentence.Replace(delimiter, ", ");
                Console.WriteLine($"[{newSentence}]");
            }
            
       }
    }
}
