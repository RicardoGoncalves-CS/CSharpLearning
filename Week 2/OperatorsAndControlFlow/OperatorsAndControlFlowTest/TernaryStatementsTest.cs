using OperatorsAndControlFlow;

namespace OperatorsAndControlFlowTest
{
    public class Tests
    {
        public class TernaryChallengeTests
        {
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
                string result = Program.GetGrade(input);
                Assert.That(result, Is.EqualTo(expected));
            }
        }
    }
}