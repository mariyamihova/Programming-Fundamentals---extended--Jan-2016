
namespace _06.Filter_Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var nameAndAge = new Dictionary<string, int>();
            var nameAndSalary = new Dictionary<string, double>();
            var nameAndPosition = new Dictionary<string, string>();
            while (input != "filter base")
            {
                var result = input.Split();
                var name = result[0];
                var otherInfo = result[2];

                if (otherInfo.Contains('.'))
                {
                    double salary = 0.0;
                    if (double.TryParse(otherInfo, out salary))
                    {
                        nameAndSalary[name] = salary;
                    }
                }
                else
                {
                    int age = 0;
                    if (int.TryParse(otherInfo, out age))
                    {

                        nameAndAge[name] = age;
                    }
                    else
                    {
                        nameAndPosition[name] = otherInfo;
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            if (input == "Position")
            {
                foreach (var nameandjob in nameAndPosition)
                {
                    Console.WriteLine($"Name: {nameandjob.Key}");
                    Console.WriteLine($"Position: {nameandjob.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (input == "Salary")
            {
                foreach (var nameandsalary in nameAndSalary)
                {
                    Console.WriteLine($"Name: {nameandsalary.Key}");
                    Console.WriteLine($"Salary: {nameandsalary.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }

            }
            else if (input == "Age")

            {
                foreach (var nameandage in nameAndAge)
                {
                    Console.WriteLine($"Name: {nameandage.Key}");
                    Console.WriteLine($"Age: {nameandage.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }

        }
    }
}
