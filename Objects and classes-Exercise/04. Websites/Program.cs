using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    class Web
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
            var result = new List<Web>();
            while (inputLine!="end")
            {
                var splittedInput=inputLine.Split(new[] { ' ', '|', ','}, StringSplitOptions.RemoveEmptyEntries);
                var info = new Web
                {
                    Host = splittedInput[0],
                    Domain = splittedInput[1],
                    Queries = splittedInput.Skip(2).ToList()
                };
                result.Add(info);
                inputLine = Console.ReadLine();
            }
            foreach (var element in result)
            {
                if (element.Queries.Count>0)
                {
                    Console.WriteLine($"https://www.{element.Host}.{element.Domain}/query?=[{string.Join("]&[",element.Queries)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{element.Host}.{element.Domain}");
                }
            }
        }
    }
}
