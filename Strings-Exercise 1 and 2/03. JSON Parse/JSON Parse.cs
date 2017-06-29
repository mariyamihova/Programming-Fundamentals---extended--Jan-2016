using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Parse
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Grades { get; set; }
    }
    class JSONParse
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
           
            var splittedInput = inputLine.Split(new [] { ' ', ',', ':', '"','[', ']','{'}, StringSplitOptions.RemoveEmptyEntries);
            var temp = string.Join(" ", splittedInput);
            var temptwo = temp.Split(new string[] { " } " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var listStudents = new List<Student>();
            foreach (var element in temptwo)
            {
               var elementTwo = element.TrimEnd(new[] { ' ', '}' });
                var studentDetails = elementTwo.Split(' ').ToList();
                var name = studentDetails[1];
                var age = studentDetails[3];
                var grades = studentDetails.Skip(5).ToList();
               
                var newStudent = new Student
                {
                    Name = name,
                    Age = int.Parse(age),
                    Grades = grades
                };
                listStudents.Add(newStudent);
            }
            foreach (var student in listStudents)
            {
                
                if (student.Grades.Count!=0)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }

            }
        }
    }
}
