
namespace Methods_and_Debugging
{
    using System;
    class Program
    {
        static void Main()
        {
            PrintReceipt();
        }
        public static void PrintUpperPart()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        public static void PrintMiddlePart()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        public static void PrintBottompart()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
        public static void PrintReceipt()
        {
            PrintUpperPart();
            PrintMiddlePart();
            PrintBottompart();
        }
    }
}
