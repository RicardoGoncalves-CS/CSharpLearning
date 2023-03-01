using OperatorsAndControlFlow;

namespace OperatorsAndControlFlowTest
{
    public class Tests
    {
        public class TernaryChallengeTests
        {
            // arrange
            [TestCase(1, "Fail")]   // Upper band
            [TestCase(20, "Fail")]  // Middle band
            [TestCase(34, "Fail")]  // Lower band
            [TestCase(35, "Resit")]
            [TestCase(53, "Resit")]
            [TestCase(64, "Resit")]
            [TestCase(65, "Pass")]
            [TestCase(70, "Pass")]
            [TestCase(79, "Pass")]
            [TestCase(80, "Distinction")]
            [TestCase(90, "Distinction")]
            [TestCase(100, "Distinction")]
            public void GivenMark_TernaryChallenge_ReturnResult(int input, string expected)
            {
                // act
                string result = Program.GetGrade(input);

                // assert
                Assert.That(result, Is.EqualTo(expected));
            }

            [TestCase(-99)]
            [TestCase(-1)]
            [TestCase(101)]
            [TestCase(9999)]
            public void GivenInvalidMark_GetGrade_ThrowsArgumentException(int mark)
            {
                // Test Exceptions
                Assert.That(() => Program.GetGrade(mark), Throws.TypeOf<ArgumentException>());

                // Test Exception with message
                Assert.That(() => Program.GetGrade(mark), Throws.TypeOf<ArgumentException>().With.Message.Contain("Mark must be between 0 to 100."));
            }
        }
    }
}