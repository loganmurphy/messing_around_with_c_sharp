using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics() {
            return new GradeStatistics();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public List<float> grades;

    }
}
