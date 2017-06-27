



namespace _09.Altitude
{
    using System;
    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split();
            double initialValue = double.Parse(text[0]);
            for (int i = 1; i < text.Length - 1; i += 2)
            {
                if (text[i] == "up")
                {
                    double number = double.Parse(text[i + 1]);
                    initialValue += number;
                    if (initialValue == 0 || initialValue < 0)
                    {
                        Console.WriteLine("crashed");
                        break;
                    }
                }
                else if (text[i] == "down")
                {
                    double number = double.Parse(text[i + 1]);
                    initialValue -= number;
                    if (initialValue == 0 || initialValue < 0)
                    {
                        Console.WriteLine("crashed");
                        break;
                    }
                }
            }
            if (initialValue > 0)
            {
                Console.WriteLine($"got through safely. current altitude: {initialValue}m");
            }

        }
    }
}
