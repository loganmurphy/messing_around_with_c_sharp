using System;

namespace GradeBook
{
    public class MainClass
    {
        public static void Main(string[] args)

        {
            GradeBook book = new GradeBook();
            book.AddGrade(100);

            foreach( int grade in book.grades) {
                Console.WriteLine(grade);
            }


            GradeBook book2 = new GradeBook();
            book2.AddGrade(95);
            book2.AddGrade(60);

            foreach (int grade in book2.grades)
            {
                Console.WriteLine(grade);
            }

        }
    }
}