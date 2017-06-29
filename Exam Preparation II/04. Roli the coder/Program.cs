using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_the_coder
{
    public class Event
    {
        public  string ID { get; set; }
        public  string Name { get; set; }
        public SortedSet<string> Participants {get; set;}
}
    class Program

    {
        static void Main(string[] args)
        {

            var inputLine = Console.ReadLine();
            var result = new List<Event>();

            while (inputLine!="Time for Code")
            {
                var splittedInput=inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                var eventID = splittedInput[0];
                var eventName = splittedInput[1];
                var participants = splittedInput.Skip(2).ToList();
                if (!eventName.StartsWith("#")|| (result.Any(x => x.ID == eventID && x.Name != eventName.TrimStart('#'))))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                if (result.Any(x => x.ID == eventID))
                {
                    Event ev = result.FirstOrDefault(e => e.ID == eventID);

                    foreach (var participant in participants)
                    {
                        ev.Participants.Add(participant);
                    }
                }
                else
                {
                    result.Add(new Event() { ID = eventID, Name = eventName.TrimStart('#'), Participants = new SortedSet<string>(participants) });
                }

                inputLine = Console.ReadLine();
            }
            foreach (var eventt in result.OrderByDescending(x=>x.Participants.Count).ThenBy(x=>x.Name))
            {
                Console.WriteLine($"{eventt.Name} - {eventt.Participants.Count}");
                foreach (var participant in eventt.Participants)
                {
                    Console.WriteLine(participant);
                }
            }
        }

    }
}
