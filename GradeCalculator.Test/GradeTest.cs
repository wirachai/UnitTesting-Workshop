using NUnit.Framework;

namespace GradeCalculator.Test
{
    [TestFixture]
    internal class GradeTest
    {
        [Test]
        public void GetGrade_ShouldReturnF_WhenScoreIs0()
        {
            // arrange
            var grade = new Grade();

            // act
            var result = grade.GetGrade(0);

            // assert
            Assert.AreEqual("F", result);
        }
    }
}