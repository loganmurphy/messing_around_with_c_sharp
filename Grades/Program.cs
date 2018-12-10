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
        }
    }
}