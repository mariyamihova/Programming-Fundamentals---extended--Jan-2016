using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam_V02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var broadcasts = new List<string>();
            var messages = new List<string>();
            var messagePattern = new Regex(@"^(\d+) \<\-\> ([a-zA-Z0-9]+)$");
            var broadcastPattern = new Regex(@"^(\D+) \<\-\> ([a-zA-Z0-9]+)$");
            while (inputLine!="Hornet is Green")
            {
                
                if (messagePattern.IsMatch(inputLine))
                {
                    var match = messagePattern.Match(inputLine);
                    var recipientsCode = match.Groups[1].Value.ToString().Reverse();
                    var reversedCode = string.Join("", recipientsCode);
                    var messageContent= match.Groups[2].Value.ToString();

                    messages.Add(reversedCode + " -> " + messageContent);
                }
                else if (broadcastPattern.IsMatch(inputLine))
                {
                    var match = broadcastPattern.Match(inputLine);
                    var message = match.Groups[1].Value.ToString();
                    var frequency = match.Groups[2].Value.ToString();

                    var frequencyDecrypted = DecryptFrequency(frequency);
                    broadcasts.Add(frequencyDecrypted + " -> " + message);
                }
                else
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count==0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine(broadcast);
                }
            }
            Console.WriteLine("Messages:");
            if (messages.Count==0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var message in messages)
                {
                    Console.WriteLine(message);
                }
            }

        }

        private static StringBuilder DecryptFrequency(string frequency)
        {
            var decrypted = new StringBuilder();
            foreach (var symbol in frequency)
            {
                if (char.IsDigit(symbol))
                {
                    decrypted.Append(symbol);
                }
                else if (char.IsLower(symbol))
                {
                    var upper = symbol.ToString().ToUpper();
                    decrypted.Append(upper);
                }
                else if (char.IsUpper(symbol))
                {
                    var lower = symbol.ToString().ToLower();
                    decrypted.Append(lower);
                }
            }
            return decrypted;
        }
    }
}
