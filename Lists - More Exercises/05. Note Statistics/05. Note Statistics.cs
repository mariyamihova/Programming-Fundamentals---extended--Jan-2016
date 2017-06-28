
namespace _05.Note_Statistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> notes = new List<string>() { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            List<double> frequence = new List<double>() { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            List<string> notesNew = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (frequence.Contains(numbers[i]))
                {
                    int index = frequence.FindIndex(x => x == numbers[i]);
                    notesNew.Add(notes[index]);
                }
            }
            Console.WriteLine($"Notes: {string.Join(" ", notesNew)}");

            List<string> sharps = new List<string>();
            List<string> naturales = new List<string>();

            foreach (var note in notesNew)
            {
                if (note.Contains("#"))
                {
                    sharps.Add(note);
                }
                else
                {
                    naturales.Add(note);
                }
            }


            Console.WriteLine($"Naturals: {string.Join(", ", naturales)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");

            double naturalesSum = 0d;
            foreach (var note in naturales)
            {
                var freqIndex = notes.IndexOf(note);
                var frequency = frequence[freqIndex];
                naturalesSum += frequency;
            }
            Console.WriteLine($"Naturals sum: {naturalesSum}");
            double sharpsSum = 0d;
            foreach (var note in sharps)
            {
                var freqIndex = notes.IndexOf(note);
                var frequency = frequence[freqIndex];
                sharpsSum += frequency;
            }
            Console.WriteLine($"Sharps sum: {sharpsSum}");
        }
    }
}
