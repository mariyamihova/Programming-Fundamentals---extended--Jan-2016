using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exam_Preparation_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersNumber = int.Parse(Console.ReadLine());
            var totalMoney = 0.0m;
            for (int i = 0; i < ordersNumber; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                var date = Console.ReadLine();
                var orderDate = DateTime.ParseExact(date, "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = long.Parse(Console.ReadLine());
                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                var coffePrice = (daysInMonth* capsulesCount) * price;
                Console.WriteLine($"The price for the coffee is: ${coffePrice:f2}");
               totalMoney += coffePrice;
            }
            Console.WriteLine($"Total: ${totalMoney:f2}");
        }
    }
}
