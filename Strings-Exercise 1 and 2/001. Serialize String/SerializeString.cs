using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize_String
{
    class SerializeString
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
            var letters = new List<char>();
            foreach (var letter in inputLine)
            {
                letters.Add(letter);
            }
            letters = letters.Distinct().ToList();
            var lettersAndIndexes = new Dictionary<char, List<int>>();

            foreach (var letter in letters)
            {
                if (!lettersAndIndexes.ContainsKey(letter))
                {
                    lettersAndIndexes[letter] = new List<int>();
                }
                int index = inputLine.IndexOf(letter);
                lettersAndIndexes[letter].Add(index);
                while (index >-1)
                {

                    index = inputLine.IndexOf(letter, index + 1);
                    if (index!=-1)
                    {
                        lettersAndIndexes[letter].Add(index);
                    }
                    
                }

            }
            foreach (var element in lettersAndIndexes)
            {
               //element.Value.RemoveAt(element.Value.Count - 1);
                Console.WriteLine($"{element.Key}:{string.Join("/", element.Value)}");
            }
        }
    }
}
