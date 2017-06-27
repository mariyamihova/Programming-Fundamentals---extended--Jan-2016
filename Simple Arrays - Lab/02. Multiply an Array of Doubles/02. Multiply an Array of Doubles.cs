


namespace _02.Multiply_an_Array_of_Doubles
{
    using System;
    class Program
    {
        static void Main()
        {
            var StringArr = Console.ReadLine().Split();
            var array = new double[StringArr.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(StringArr[i]);
            }
            double p = double.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= p;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
