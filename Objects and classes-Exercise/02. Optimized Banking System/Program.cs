using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedBankingSystem
{
    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
            var result = new List<BankAccount>();
            while (inputLine!="end")
            {
                var splittedinput=inputLine.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                var balance = decimal.Parse(splittedinput[2]);
                var account = new BankAccount
                {
                    Name = splittedinput[1],
                    Bank = splittedinput[0],
                    Balance = balance
                };
                result.Add(account);
                inputLine = Console.ReadLine();
            }
            foreach (var element in result.OrderByDescending(x=>x.Balance).ThenBy(x=>x.Bank.Length))
            {
                Console.WriteLine($"{element.Name} -> {element.Balance} ({element.Bank})");
            }
        }
    }
}
