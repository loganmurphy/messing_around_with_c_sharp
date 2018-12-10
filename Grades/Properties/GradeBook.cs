using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public List<float> grades;

    }
}
