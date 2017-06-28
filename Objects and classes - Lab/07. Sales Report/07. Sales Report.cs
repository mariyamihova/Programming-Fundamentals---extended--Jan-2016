

namespace SimpleClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
  

    class SalesReport
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(' ');
                var currentElement = new Sale
                {
                    town = inputLine[0],
                    product = inputLine[1],
                    price = double.Parse(inputLine[2]),
                    quantity = double.Parse(inputLine[3])

                };
                if (!result.ContainsKey(currentElement.town))
                {
                    result[currentElement.town] = 0;
                }
                result[currentElement.town] += currentElement.quantity * currentElement.price;
            }
            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
            }
        }
        public class Sale
        {
            public string town { get; set; }
            public string product { get; set; }
            public double price { get; set; }
            public double quantity { get; set; }

        }
    }
}