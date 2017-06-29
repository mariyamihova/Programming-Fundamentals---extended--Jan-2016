using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_30._04._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthInCm = int.Parse(Console.ReadLine());
            var widthInMm = decimal.Parse(Console.ReadLine());
            var remainder = 0.0m;
           
            var lengthinMM = lengthInCm * (long)100;
            try
            {
                remainder = lengthinMM % widthInMm;
            }
            catch (DivideByZeroException)
            {
                
            }
                if (remainder != 0)
                {
                    var percentage = (decimal)lengthinMM / ((decimal)0.01 * widthInMm);
                    Console.WriteLine($"{percentage:f2}%");

                }
                else
                {
                    var result = lengthinMM * widthInMm;
                    Console.WriteLine($"{result:f2}");
                }
            
        }
    }
}
