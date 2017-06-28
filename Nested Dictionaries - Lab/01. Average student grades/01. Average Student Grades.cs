
namespace Nested_Dictionaries_Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split();
                var name = inputLine[0];
                var grade = double.Parse(inputLine[1]);
                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            foreach (var nameAndGrade in grades)
            {
                var gradesList = new List<string>();
                foreach (var grade in nameAndGrade.Value)
                {
                    var gradeStr = String.Format("{0:f2}", grade);

                    gradesList.Add(gradeStr);
                }

                Console.WriteLine("{0} -> {1} (avg: {2:f2})", nameAndGrade.Key, string.Join(" ", gradesList), nameAndGrade.Value.Average());
            }
        }
    }
}
