using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_V03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            

            for (int i = 0; i < beehives.Count; i++)
            {
                var hornetsSumPower = (long)hornets.Sum();
                if (hornets.Count==0)
                {
                    break;
                }
                if (hornetsSumPower>beehives[i])
                {
                    beehives[i] = 0L;
                }
                else
                {
                    var leftBeehives = beehives[i] - hornetsSumPower;
                    beehives[i] = leftBeehives;
                    hornets.RemoveAt(0);
                }
            }
            var beehivesLeft = new List<long>();
            foreach (var bee in beehives)
            {
                if (bee>0)
                {
                    beehivesLeft.Add(bee);
                }

            }
         

            if (beehivesLeft.Count>=1)
            {
                Console.WriteLine(string.Join(" ", beehivesLeft));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
