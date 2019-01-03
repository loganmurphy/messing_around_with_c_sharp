﻿using System;

namespace Grades
{
    public class MainClass
    {
        public static void Main(string[] args)

        {

            GradeBook book = new GradeBook();
            book.NameChanged += OnNameChanged;

            book.Name = "My grade book";
            book.Name = "Another new grade book";

            book.AddGrade(100);
            book.AddGrade(95);
            book.AddGrade(60);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
    }
}