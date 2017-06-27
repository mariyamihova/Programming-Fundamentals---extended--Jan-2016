


namespace _10.Ballistics_Training
{
    using System;
    class Program
    {
        static void Main()
        {
            double[] coordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();
            string[] text = Console.ReadLine().Split();

            double initialValueX = 0;
            double initialValueY = 0;

            for (int i = 0; i < text.Length; i += 2)
            {
                if (text[i] == "up")
                {
                    double number = double.Parse(text[i + 1]);
                    initialValueY += number;
                }

                else if (text[i] == "down")
                {
                    double number = double.Parse(text[i + 1]);
                    initialValueY -= number;

                }
                else if (text[i] == "left")
                {
                    double number = double.Parse(text[i + 1]);
                    initialValueX -= number;
                }
                else if (text[i] == "right")
                {
                    double number = double.Parse(text[i + 1]);
                    initialValueX += number;
                }
            }
            Console.WriteLine($"firing at [{initialValueX}, {initialValueY}]");

            if ((initialValueX == coordinates[0]) && (initialValueY == coordinates[1]))
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
   