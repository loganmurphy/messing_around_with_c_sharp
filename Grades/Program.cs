using System;

namespace GradeBook
{
    public class MainClass
    {
        public static void Main(string[] args)

        {
            GradeBook book = new GradeBook();
            book.AddGrade(1);
            Console.WriteLine("Grade Added");

        }
    }
}