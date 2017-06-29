using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var driversNames = Console.ReadLine().Split().ToList();
            var trackLayout= Console.ReadLine().Split().Select(double.Parse).ToList();
            var checkpointIndex= Console.ReadLine().Split().Select(int.Parse).ToList();
            //var result = new Dictionary<string,double>();
      
            foreach (var driver in driversNames)
            {
                double initialFuel = (int)(driver[0]);
                for (int i = 0; i < trackLayout.Count; i++)
                {
                    if (!checkpointIndex.Contains(i))
                    {
                        initialFuel -= trackLayout[i];
                        if (initialFuel<=0)
                        {
                            Console.WriteLine($"{driver} - reached {i}");
                            break;
                        }
                    }
                    else
                    {
                        initialFuel += trackLayout[i];
                    }
                }
                if (initialFuel>0)
                {
                    Console.WriteLine($"{driver} - fuel left {initialFuel:f2}");
                }
                
            }
        }
    }
}
