using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_stringify
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }
    class JSON
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
            var studentList = new List<Student>();

            while (inputLine!="stringify")
            {
                var splittedInput = inputLine.Split(new[] { ':', '-', '>' },StringSplitOptions.RemoveEmptyEntries);
                var name = splittedInput[0].Trim();
                var age = int.Parse(splittedInput[1].Trim());
                var grades = new List<int>();
               
                if (splittedInput.Length>2)
                {
                   grades = splittedInput[2].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                }
              

                var newStudent = new Student
                {
                    Name = name,
                    Age = age,
                    Grades = grades

                };
                studentList.Add(newStudent);
                inputLine = Console.ReadLine();
            }
            Console.Write("[");
            //foreach (var student in studentList)
            //{
            //    Console.Write("{");
            //    Console.Write($"name:\"{student.Name}\",age: {student.Age},grades:[{string.Join(", ", student.Grades)}]}}");
            //    Console.Write(",");
            //    Console.Write("}");
            //}
            //Console.WriteLine("]");
            for (int i = 0; i <studentList.Count-1; i++)
            {
                if (studentList[i].Grades.Count!=0)
                {
                    Console.Write("{");
                    Console.Write($"name:\"{studentList[i].Name}\",age:{studentList[i].Age},grades:[{string.Join(", ", studentList[i].Grades)}]}}");
                    Console.Write(",");
                }
                else
                {
                    Console.Write("{");
                    Console.Write($"name:\"{studentList[i].Name}\",age:{studentList[i].Age},grades:[]}}");
                    Console.Write(",");
                }
                
                
            }
            Console.Write("{");
            Console.Write($"name:\"{studentList[studentList.Count-1].Name}\",age:{studentList[studentList.Count - 1].Age},grades:[{string.Join(", ", studentList[studentList.Count - 1].Grades)}]}}");
           
            Console.WriteLine("]");
        }
    }
}
