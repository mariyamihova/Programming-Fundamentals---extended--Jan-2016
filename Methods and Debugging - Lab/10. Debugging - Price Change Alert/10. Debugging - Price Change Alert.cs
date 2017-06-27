
namespace _10.Debugging_Price_Change_Alert
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double lastAvailablePrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double newestPrice = double.Parse(Console.ReadLine());
                double difference = PercentageCalculation(lastAvailablePrice, newestPrice);

                bool isSignificantDifference = hasDifference(difference, threshold);

                string message = GetMessageString(newestPrice, lastAvailablePrice, difference, isSignificantDifference);
                lastAvailablePrice = newestPrice;

                Console.WriteLine(message);
            }
        }

        private static string GetMessageString(double newestPrice, double lastAvailablePrice, double difference, bool hasSignificantDifference)
        {
            string message = "";
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", newestPrice);
            }
            else if (!hasSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastAvailablePrice, newestPrice, difference * 100);
            }
            else if (hasSignificantDifference && difference > 0)
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastAvailablePrice, newestPrice, difference * 100);
            }
            else if (hasSignificantDifference && difference < 0)
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastAvailablePrice, newestPrice, difference * 100);
            }

            return message;
        }

        private static bool hasDifference(double difference, double threshold)
        {
            if (Math.Abs(difference) >= threshold)
            {
                return true;
            }
            return false;
        }

        private static double PercentageCalculation(double oldPrice, double newPrice)
        {
            double percent = (newPrice - oldPrice) / oldPrice;
            return percent;
        }
    }
}
