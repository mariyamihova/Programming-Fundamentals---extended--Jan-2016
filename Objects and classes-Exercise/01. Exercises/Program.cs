using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses_Exercises
{
    class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
            var result = new List<Exercise>();

            while (inputLine!="go go go")
            {
                var splittedInput=inputLine.Split(new [] { ' ','-','>',','}, StringSplitOptions.RemoveEmptyEntries);

                Exercise exercise = new Exercise
                {
                    Topic = splittedInput[0],
                    CourseName = splittedInput[1],
                    JudgeContestLink = splittedInput[2],
                    Problems = splittedInput.Skip(3).ToList()
                };
                result.Add(exercise);
                inputLine = Console.ReadLine();
            }

            foreach (var element in result)
            {
                int counter = 1;
                Console.WriteLine($"Exercises: {element.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{element.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {element.JudgeContestLink}");
                
                for (int i = 0; i < element.Problems.Count; i++)
                {
                    Console.WriteLine($"{counter++}. {element.Problems[i]}");

                }
            }
        }
        
    }
    
}
