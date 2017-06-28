
namespace _05.User_Logins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, string>();

            while (input != "login")
            {
                var result = input.Split();
                var name = result[0];
                var password = result[2];
                if (!dictionary.ContainsKey(name))
                {
                    dictionary[name] = string.Empty;
                }

                dictionary[name] = password;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            var attempts = 0;
            while (input != "end")
            {
                var result = input.Split();
                var name = result[0];
                var password = result[2];
                if (dictionary.ContainsKey(name))
                {
                    string value = string.Empty;
                    bool exists = dictionary.TryGetValue(name, out value);
                    if (value == password)
                    {
                        Console.WriteLine($"{name}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{name}: login failed");
                        attempts++;
                    }
                }
                else if (!dictionary.ContainsKey(name))
                {
                    Console.WriteLine($"{name}: login failed");
                    attempts++;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"unsuccessful login attempts: {attempts}");

        }
    }
    }

