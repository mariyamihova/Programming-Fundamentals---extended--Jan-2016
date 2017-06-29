using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var listedParticipants = int.Parse(Console.ReadLine());
            var laps = int.Parse(Console.ReadLine());
            var trackLength= int.Parse(Console.ReadLine());
            var trackCapacity= int.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());

            var maximumRunners = marathonDays * trackCapacity;
            var runners = 0;

            if (maximumRunners>=listedParticipants)
            {
                runners = listedParticipants;
            }
            else
            {
                runners = maximumRunners;
            }

            long totalKM = ((long)runners * laps * trackLength)/1000;
            var moneyRaised = totalKM * moneyPerKilometer;
            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
