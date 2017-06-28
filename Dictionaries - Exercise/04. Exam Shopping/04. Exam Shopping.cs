
namespace _04.Exam_Shopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Program
    {
        static void Main()
        {
            var weRead = Console.ReadLine();
            var products = new Dictionary<string, int>();

            while (weRead != "shopping time")
            {
                var input = weRead.Split();
                var stock = input[1];
                var quantity = int.Parse(input[2]);

                if (!products.ContainsKey(stock))
                {
                    products[stock] = 0;
                }
                products[stock] += quantity;

                weRead = Console.ReadLine();
            }

            weRead = Console.ReadLine();   // четеш ред

            while (weRead != "exam time")
            {
                var input = weRead.Split();
                var stock = input[1];
                var quantity = int.Parse(input[2]);

                if (products.ContainsKey(stock))
                {
                    if (products[stock] == 0)
                    {
                        Console.WriteLine($"{stock} out of stock");
                    }
                    else if (quantity > products[stock])
                    {
                        products[stock] = 0;
                    }
                    else
                    {
                        products[stock] -= quantity;
                    }

                }
                else if (!products.ContainsKey(stock))
                {
                    Console.WriteLine($"{stock} doesn't exist");
                }

                weRead = Console.ReadLine();
            }

            foreach (var item in products)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
