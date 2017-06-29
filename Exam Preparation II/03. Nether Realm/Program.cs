using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realm
{
    public class Deamon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            var result = new List<Deamon>();

            foreach (var deamon in inputLine)
            {
                var lettersRegex = new Regex(@"[^\d\.\+\-\*\/\s\,]");
                var letters = lettersRegex.Matches(deamon);
                var health = 0;
                foreach (Match letter in letters)
                {
                    foreach (char c in letter.ToString())
                    {
                        health += c;
                    }
                }

                var numbersRegex = new Regex(@"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)");//-?\d+\.?\d*
                var numbers = numbersRegex.Matches(deamon);
                var damage = 0.0;

                foreach (Match number in numbers)
                {
                    damage += double.Parse(number.ToString());
                }
                var modificatorsRegex = new Regex(@"\*|\/");
                var modificators = modificatorsRegex.Matches(deamon);

                foreach (Match modificator in modificators)
                {
                    if (modificator.ToString() == "*")
                    {
                        damage *= 2;
                    }
                    else if (modificator.ToString() == "/")
                    {
                        damage /= 2;
                    }
                }

                var newDeamon = new Deamon
                {
                    Name = deamon,
                    Health = health,
                    Damage = damage
                };
                result.Add(newDeamon);
            }


            foreach (var participant in result.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{participant.Name} - {participant.Health} health, {participant.Damage:f2} damage ");
            }
        }
    }
}