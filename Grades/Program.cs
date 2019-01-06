using System;

namespace Grades
{
    public class MainClass
    {
        public static void Main(string[] args)

        {
            GradeBook book = new GradeBook();

            book.AddGrade(100);
            book.AddGrade(95);
            book.AddGrade(60);

            GradeStatistics stats = book.ComputeStatistics();

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }
    }
}