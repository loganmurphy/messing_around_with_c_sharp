using System;

namespace Grades
{
    public class MainClass
    {
        public static void Main(string[] args)

        {
            GradeBook book = new GradeBook();

            try
            {
                Console.WriteLine("What would you like to call your grade book?");
                book.Name = Console.ReadLine();
            }
            catch(AggregateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            book.AddGrade(100);
            book.AddGrade(95);
            book.AddGrade(60);
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine($"{book.Name}:");
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