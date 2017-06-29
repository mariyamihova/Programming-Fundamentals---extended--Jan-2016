using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var guestsCount = int.Parse(Console.ReadLine());
           var bananasPrice= decimal.Parse(Console.ReadLine());
            var eggsPrice= decimal.Parse(Console.ReadLine());
            var berriesPriceKG= decimal.Parse(Console.ReadLine());
            var setsToBeCooked = Math.Ceiling(guestsCount / 6.00);

            var priceForOneSet = 2 * bananasPrice + 4 * eggsPrice + ((decimal)0.2 * berriesPriceKG);
            var moneyNeeded = (int)setsToBeCooked * priceForOneSet;

            if (moneyNeeded<=money)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                var willNeed = moneyNeeded-money;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {willNeed:f2}lv more.");
            }
        }
    }
}
