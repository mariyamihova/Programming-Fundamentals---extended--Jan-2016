


namespace _09.Reversed_chars
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            char reversed1 = thirdLetter;
            char reversed2 = secondLetter;
            char reversed3 = firstLetter;
            Console.WriteLine("{0}{1}{2}", reversed1, reversed2, reversed3);
        }
    }
}
