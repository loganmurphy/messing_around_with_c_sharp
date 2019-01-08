using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook
    {

        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics() {
            GradeStatistics stats = new GradeStatistics();
            Console.WriteLine("GradeBook: ComputeStatistics");

            float sum = 0;

            foreach (float grade in grades) 
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name
        {

            get => _name;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                if (NameChanged != null && _name != value)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;   
                   
                    NameChanged(this, args);
                }

                _name = value;
                
            }
        }

        public event NameChangedDelegate NameChanged;
        protected List<float> grades;
        private string _name;
    }
}
