using NUnit.Framework;
using System;

namespace Grades.Tests
{
    [TestFixture()]
    public class GradeBookTests
    {
        [Test()]
        public void ComputesHighestGrade()
        {
            GradeBook gradebook = new GradeBook();
            gradebook.AddGrade(100);
            gradebook.AddGrade(25);

            GradeStatistics result = gradebook.ComputeStatistics();
            Assert.AreEqual(100, result.HighestGrade);
        }

        [Test()]
        public void ComputesLowestGrade()
        {
            GradeBook gradebook = new GradeBook();
            gradebook.AddGrade(100);
            gradebook.AddGrade(25);

            GradeStatistics result = gradebook.ComputeStatistics();
            Assert.AreEqual(25, result.LowestGrade);
        }

        [Test()]
        public void ComputesAverageGrade()
        {
            GradeBook gradebook = new GradeBook();
            gradebook.AddGrade(100);
            gradebook.AddGrade(95);
            gradebook.AddGrade(60);

            GradeStatistics result = gradebook.ComputeStatistics();
            Assert.AreEqual((100 + 95 + 60) / 3, result.AverageGrade);
        }
    }
}