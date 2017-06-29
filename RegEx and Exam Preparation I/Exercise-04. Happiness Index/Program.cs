using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var happyPattern = new Regex(@":\)|:D|;\)|:\*|:]|;]|:]|:}|;}|\(:|\*:|c:|\[:|\[;");
            var sadPattern = new Regex(@":\(|D:|;\(|:\[|;\[|:\{|;\{|\):|:c|\]:|\];");

            var happyCount = happyPattern.Matches(input).Count;
            var sadCount = sadPattern.Matches(input).Count;
            double happinessIndex = happyCount / (double)sadCount;
            var emoticon = PrintEmoticon(happinessIndex);

            Console.WriteLine($"Happiness index: {happinessIndex:f2} {emoticon}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");


        }

        private static string PrintEmoticon(double happinessIndex)
        {
            if (happinessIndex >= 2)
            {
                return ":D";
            }
            else if (happinessIndex > 1)
            {
                return ":)";
            }
            else if (happinessIndex == 1)
            {
                return ":|";
            }
            else
            {
                return ":(";
            }
        }
    }
}
