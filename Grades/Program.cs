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

            Console.WriteLine("Avg: {0}, High: {1}, Low: {2}", stats.AverageGrade, 
                          stats.HighestGrade, stats.LowestGrade);
        }
    }
}