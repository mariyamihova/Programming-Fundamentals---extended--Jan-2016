using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList(); ;
            var inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                var inputParam = inputLine.Split(' ');
                var command = inputParam[0];

                switch (command)
                {
                    case "reverse":
                        var reverseStart = int.Parse(inputParam[2]);
                        var reverseCount = int.Parse(inputParam[4]);
                        if(IsValid(collection,reverseStart,reverseCount))
                        {
                            ReverseRange(collection, reverseCount, reverseStart);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");

                        }

                        break;

                    case "sort":
                        var sortStart = int.Parse(inputParam[2]);
                        var sortCount = int.Parse(inputParam[4]);
                        if (IsValid(collection,sortStart,sortCount))
                        {
                            SortRange(collection, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                       
                        break;

                    case "rollRight":
                        var rollRightCount = int.Parse(inputParam[1]);
                        if (rollRightCount>0)
                        {
                            RollRightRange(collection, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollLeft":
                        var rollLeftCount = int.Parse(inputParam[1]);
                        
                        if (rollLeftCount>0)
                        {
                            RollLeftRange(collection, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }



                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", collection)}]");
        }

        private static bool IsValid(List<string> collection, int start, int count)
        {
            var result = start >= 0 && start < collection.Count && count >= 0 && (count + start) <= collection.Count;
            return result;
        }

        private static void ReverseRange(List<string> collection, int reverseCount, int reverseStart)
        {
            collection.Reverse(reverseStart, reverseCount);
        }
        private static void SortRange(List<string> collection, int sortStart, int sortCount)
        {
            collection.Sort(sortStart, sortCount, null);
        }

        private static void RollRightRange(List<string> collection, int rollRightCount)
        {
            var rotations = rollRightCount % collection.Count;
            for (int i = 0; i < rotations; i++)
            {
                var lastElement = collection[collection.Count - 1];
                for (int j = collection.Count - 1; j > 0; j--)
                {
                    collection[j] = collection[j - 1];
                }
                collection[0] = lastElement;
            }
        }
        private static void RollLeftRange(List<string> collection, int rollLeftCount)
        {
            var rotations = rollLeftCount % collection.Count;
            for (int i = 0; i < rotations; i++)
            {
                var firstElement = collection[0];
                for (int j = 0; j < collection.Count - 1; j++)
                {
                    collection[j] = collection[j + 1];
                }
                collection[collection.Count - 1] = firstElement;
            }
        }
    }
}
