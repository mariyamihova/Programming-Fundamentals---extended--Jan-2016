
namespace _07.Resizable_Array
{
    using System;
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            var result = new List<int>();

            while (array[0] != "end")
            {
                if (array[0] == "push")
                {
                    result.Add(int.Parse(array[1]));
                }
                else if (array[0] == "pop")
                {
                    result.RemoveAt(result.Count - 1);
                }
                else if (array[0] == "removeAt")
                {
                    result.RemoveAt(int.Parse(array[1]));
                }
                else if (array[0] == "clear")
                {
                    result.Clear();
                }
                array = Console.ReadLine().Split(' ').ToArray();
            }
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty array");
            }
        }
    }
}
