using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs_official
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            var initialIndexes = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            var field = new long[size];

            foreach (var index in initialIndexes)
            {
                if (index>=0&&index<size)
                {
                    field[index] = 1;
                }
            }

            var input = Console.ReadLine();

            while (input != "end")
            {
                var bugInfo = input.Split().ToArray();
                var fromIndex = long.Parse(bugInfo[0]);
                var direction = bugInfo[1];
                var moveWith = long.Parse(bugInfo[2]);

                var arrayLength = field.Length;

                if (fromIndex < 0||fromIndex>=arrayLength)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (field[fromIndex]==0)
                {
                    input = Console.ReadLine();
                    continue;
                }
               
                if (direction=="right")
                {
                    var moveTo = fromIndex + moveWith;
                    if (moveTo<0||moveTo>=arrayLength)
                    {
                        field[fromIndex] = 0;
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        field[fromIndex] = 0;
                        while (fromIndex>=0&&fromIndex<arrayLength&&moveTo>=0&&moveTo<arrayLength)
                        {
                            if (field[moveTo]==0)
                            {
                                field[moveTo] = 1;
                                break;
                            }
                            else
                            {
                                moveTo += moveWith;
                            }
                        }
                    }
                        
                }
                else if(direction=="left")
                {
                    var moveTo = fromIndex - moveWith;
                    if (moveTo < 0 || moveTo >= arrayLength)
                    {
                        field[fromIndex] = 0;
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        field[fromIndex] = 0;
                        while (fromIndex >= 0 && fromIndex < arrayLength && moveTo >= 0 && moveTo < arrayLength)
                        {
                            if (field[moveTo] == 0)
                            {
                                field[moveTo] = 1;
                                break;
                            }
                            else
                            {
                                moveTo -= moveWith;
                            }
                        }
                    }
                }
                



                    input= Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
