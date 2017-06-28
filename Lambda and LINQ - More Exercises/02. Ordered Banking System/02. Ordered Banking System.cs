


namespace _02.Ordered_Banking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, decimal>>();
            var inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            while (inputLine[0] != "end")
            {
                var bankName = inputLine[0];
                var account = inputLine[1];
                var balance = decimal.Parse(inputLine[2]);
                if (!result.ContainsKey(bankName))
                {
                    result[bankName] = new Dictionary<string, decimal>();
                }
                if (!result[bankName].ContainsKey(account))
                {
                    result[bankName].Add(account, 0);
                }
                result[bankName][account] += balance;

                inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }



            foreach (var bank in result.OrderByDescending(bank => bank.Value.Sum(account => account.Value)).ThenByDescending(bank => bank.Value.Max(account => account.Value)))
            {

                foreach (var account in bank.Value.OrderByDescending(account => account.Value))
                {
                    Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})");
                }
            }
        }
    }
}
