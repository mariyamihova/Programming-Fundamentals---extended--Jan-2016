using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class PalinDromes
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split(new char[] { ',', '!', '?', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<string>();
            foreach (var word in inputLine)
            {
                bool isPolindrome = CheckIsPolindrome(word);
                if (isPolindrome)
                {
                    result.Add(word);
                }
            }
            var polindromes = result.Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", polindromes));
        }

        public static bool CheckIsPolindrome(string word)
        {
            string reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            if (reversed == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
