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
    }
}
