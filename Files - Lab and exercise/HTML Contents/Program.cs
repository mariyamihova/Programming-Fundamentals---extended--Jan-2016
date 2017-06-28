

namespace HTML_Contents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var lines = File.ReadAllLines("input.txt");
            var body = new List<string>();
            var title = string.Empty;

            
            foreach (var line in lines)
            {
                if (line=="exit")
                {
                    break;
                }
                var splittedLine = line.Split(' ');
                var tag = splittedLine[0];
                var content = splittedLine[1];
                if (tag != "title")
                {
                    body.Add($"\t<{tag}>{content}</{tag}>");
                }
                else
                {
                    title = content;
                }
            }
            var result = new StringBuilder();
            result.AppendLine("<!DOCTYPE html>");
            result.AppendLine("<html>");
            result.AppendLine("<head>");
            if (title!=string.Empty)
            {
                result.AppendLine($"\t<title>{title}</title>");
            }
            result.AppendLine("<head>");
            result.AppendLine("<body>");
            if (body.Any())
            {
                result.AppendLine(string.Join(Environment.NewLine, body));
            }
            result.AppendLine("<body>");
            result.AppendLine("<html>");
            Console.WriteLine(result.ToString().Trim());
            File.WriteAllText("index.html", result.ToString().Trim());
        }
    }
}
