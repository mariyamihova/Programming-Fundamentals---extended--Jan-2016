﻿
namespace _03.Exact_sum_of_real_numbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());


            }
            Console.WriteLine(sum);
        }
    }
}
