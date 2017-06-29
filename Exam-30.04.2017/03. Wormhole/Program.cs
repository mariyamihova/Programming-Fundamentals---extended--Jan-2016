using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToList();
            var count = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i]==0)
                {
                    count++;
                    continue;
                }
                else
                {
                    count++;
                    var value = 0;
                    var element = array[i].ToString();
                    var isNumber = int.TryParse(element, out value);
                    if (isNumber)
                    {
                        array[i] = 0;
                        i = value;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
