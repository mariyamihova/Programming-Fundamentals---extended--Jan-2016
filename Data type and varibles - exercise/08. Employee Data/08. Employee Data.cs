
namespace _08.Employee_Data
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string fisrtName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalID = long.Parse(Console.ReadLine());
            int employeeNum = int.Parse(Console.ReadLine());


            Console.WriteLine("First name:{0}", fisrtName);
            Console.WriteLine("Last name:{0}", lastName);
            Console.WriteLine("Age:{0}", age);
            Console.WriteLine("Gender:{0}", gender);
            Console.WriteLine("Personal ID:{0}", personalID);
            Console.WriteLine("Unique Employee number:{0}", employeeNum);
        }
    }
}
