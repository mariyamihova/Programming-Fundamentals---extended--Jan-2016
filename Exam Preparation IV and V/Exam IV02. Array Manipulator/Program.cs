using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_IV02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToList();



           var commands = Console.ReadLine();

            while (commands!="end")
            {
                var splittedCommands = commands.Split().ToList();
                var command = splittedCommands[0];

                switch (command)
                {
                    case "exchange":
                        var exchangeIndex = int.Parse(splittedCommands[1]);
                        if (exchangeIndex >=array.Count || exchangeIndex < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            array = ExchangePositions(array, exchangeIndex);
                        }
                        break;
                    case "max":
                        var number = splittedCommands[1];
                        if (number=="odd")
                        {
                            MaxOddNumber(array);
                            
                        }
                        else
                        {
                            MaxEvenNumber(array);
                            
                        }
                        break;
                    case "min":
                        var minNumber = splittedCommands[1];
                        if (minNumber == "odd")
                        {
                            MinOddNumber(array);

                        }
                        else
                        {
                            MinEvenNumber(array);

                        }
                        break;
                    case "first":
                        var firstCount = int.Parse(splittedCommands[1]);
                        var firstEvenOdd = splittedCommands[2];
                        if (firstEvenOdd=="even")
                        {
                            FirstEvenNumbers(array, firstCount);
                        }
                        else
                        {
                            FirstOddNumbers(array, firstCount);
                        }

                        break;
                    case "last":
                        var lastCount = int.Parse(splittedCommands[1]);
                        var lastEvenOdd = splittedCommands[2];
                        if (lastEvenOdd == "even")
                        {
                            LastEvenNumbers(array, lastCount);
                        }
                        else
                        {
                            LastOddNumbers(array, lastCount);
                        }
                        break;
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static void LastOddNumbers(List<int> array, int lastCount)
        {
            var oddNumbers = new List<int>();


            foreach (var num in array)
            {
                if (num % 2 != 0)
                {
                    oddNumbers.Add(num);
                }
            }
            if (oddNumbers.Count == 0&&lastCount<array.Count)
            {
                Console.WriteLine("[]");
            }
           else if (lastCount > array.Count)
            {
                Console.WriteLine("Invalid count");
            }
            
            else
            {
                var result = oddNumbers.Skip(oddNumbers.Count - lastCount).Take(lastCount).ToList();
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }
        private static void LastEvenNumbers(List<int> array, int lastCount)
        {
            var evenNumbers = new List<int>();


            foreach (var num in array)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }
             if (evenNumbers.Count == 0&&lastCount<array.Count)
            {
                Console.WriteLine("[]");
            }
            else if (lastCount >= array.Count)
            {
                Console.WriteLine("Invalid count");
            }
            
            else
            {
                var result = evenNumbers.Skip(evenNumbers.Count-lastCount).Take(lastCount).ToList();
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }

        private static void FirstOddNumbers(List<int> array, int firstCount)
        {
            var oddNumbers = new List<int>();


            foreach (var num in array)
            {
                if (num % 2 != 0)
                {
                    oddNumbers.Add(num);
                }
            }
             if (oddNumbers.Count == 0)
            {
                Console.WriteLine("[]");
            }
           else if (firstCount > array.Count)
            {
                Console.WriteLine("Invalid count");
            }
            
            else
            {
                var result = oddNumbers.Take(firstCount).ToList();
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }

        private static void FirstEvenNumbers(List<int> array, int firstCount)
        {
            var evenNumbers = new List<int>();


            foreach (var num in array)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }
            if (evenNumbers.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else if (firstCount>array.Count)
            {
                Console.WriteLine("Invalid count");
            }
            
            else
            {
                var result = evenNumbers.Take(firstCount).ToList();
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
            
        }

        private static void MinEvenNumber(List<int> array)
        {
            var evenNumbers = new List<int>();


            foreach (var num in array)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }
            if (evenNumbers.Count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                var minEven = evenNumbers.Min();
                var index = array.FindLastIndex(x => x == minEven);
                Console.WriteLine(index);
            }
        }

        private static void MinOddNumber(List<int> array)
        {
            var oddNumbers = new List<int>();
            foreach (var num in array)
            {
                if (num % 2 != 0)
                {
                    oddNumbers.Add(num);
                }
            }

            if (oddNumbers.Count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                var minOdd = oddNumbers.Min();
                var index = array.FindLastIndex(x => x == minOdd);
                Console.WriteLine(index);
            }
        }

        private static void MaxEvenNumber(List<int> array)
        {
            var evenNumbers = new List<int>();


            foreach (var num in array)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }
            if (evenNumbers.Count==0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                var maxEven = evenNumbers.Max();
                var index = array.FindLastIndex(x => x == maxEven);
                Console.WriteLine(index);
            }
           
        }

        private static void MaxOddNumber(List<int> array)
        {
            var oddNumbers = new List<int>();
            

            foreach (var num in array)
            {
                if (num%2!=0)
                {
                    oddNumbers.Add(num);
                }
            }

            if (oddNumbers.Count==0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                var maxOdd = oddNumbers.Max();
                var index = array.FindLastIndex(x => x == maxOdd);
                Console.WriteLine(index);
            }
            

        }

        private static List<int> ExchangePositions( List<int> array,int exchangeIndex)
        {
            var rightPart = array.Skip(exchangeIndex + 1).ToList();
            var leftPart = array.Take(exchangeIndex + 1).ToList();
            var result = new List<int>();
            result.AddRange(rightPart);
            result.AddRange(leftPart);
           return result;
        }
    }
}
