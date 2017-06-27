
namespace _06.Notifications
{
    using System;
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());


            for (int i = 0; i < number; i++)
            {
                string result = Console.ReadLine();
                if (result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();

                    Console.WriteLine(ShowSuccess(operation, message));
                }
                else if (result == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());

                    Console.WriteLine(ShowError(operation, code));
                }
                else
                {
                    continue;
                }
            }
        }
        public static string ShowSuccess(string operation, string message)
        {

            string output = ($"Successfully executed {operation}.\n==============================\nMessage: {message}.");
            return output;
        }
        public static string ShowError(string operation, int code)
        {
            if (code < 0)
            {
                string output = ($"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Internal System Failure.");
                return output;
            }
            else
            {
                string output = ($"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Invalid Client Data.");
                return output;
            }
        }

    }
}

