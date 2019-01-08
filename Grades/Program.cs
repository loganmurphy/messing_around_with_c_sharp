using System;
using System.IO;

namespace Grades
{
    public class MainClass
    {
        public static void Main(string[] args)

        {
            GradeBook book = new ThrowAwayGradeBook();

            GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);
        }

        private static void WriteResults(GradeBook book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine($"{book.Name}:");
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(GradeBook book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);

            }
        }

        private static void AddGrades(GradeBook book)
        {
            book.AddGrade(100);
            book.AddGrade(95);
            book.AddGrade(60);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("What would you like to call your grade book?");
                book.Name = Console.ReadLine();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Something went wrong");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("Finished");
            }
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