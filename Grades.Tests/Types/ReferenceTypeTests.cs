using System;
using NUnit.Framework;

namespace Grades.Tests.Types
{
    [TestFixture()]
    public class TypeTests
    {
        [Test()]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "My grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }

        [Test()]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [Test()]
        public void StringComparisons()
        {
            string name1 = "Logan";
            string name2 = "logan";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [Test()]
        public void ReferenceTypesPassByVAlue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(out book2);
            Assert.AreEqual("A GradeBook", book2.Name);
        }

        void GiveBookAName(out GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A GradeBook";
        }

        [Test()]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);

            Assert.AreEqual(47, x);
        }

        public void IncrementNumber(ref int number)
        {
            number++;
        }

        [Test()]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2019, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [Test()]
        public void UppercaseString()
        {
            string name = "logan";
            name = name.ToUpper();

            Assert.AreEqual("LOGAN", name);
        }

        [Test()]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }
    }
}
