using NUnit.Framework;

namespace AdvancedNUnit
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup() { }

        [TestCase(2, 4, 6)]
        [Category("Happy Path")]
        public void Add_Always_ReturnsExpectedResult(int x, int y, int expResult)
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = x, Num2 = y };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expResult), "optional failure message");
            
            //Assert.AreEqual(expectedResult, result, "optional failure message");
        }

        [TestCaseSource("AddCases")]
        [Category("Happy Path")]
        public void Add_Always_ReturnsExpectedResult_TestCaseSource(int x, int y, int expResult)
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = x, Num2 = y };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expResult), "optional failure message");

            //Assert.AreEqual(expectedResult, result, "optional failure message");
        }

        // field
        // This must be static
        private static object[] AddCases =
        {
            new int[] { 2, 4, 6 },
            new int[] { 1, 2, 3 }
        };

        [Test]
        [Category("Sad Path")]
        public void DivisibleBy3_GivenAnInputOf7_ReturnsFalse()
        {
            // Arrange
            var subject = new Calculator { Num1 = 7 };
            // Act
            var result = subject.DivisibleBy3();
            // Assert
            Assert.That(result, Is.False);
        }

        // The tests below are not for the Calculator class but to test some advanced NUnit testing
        [Test]
        public void ToString_ContainsTheStringCalculator()
        {
            // Arrange
            Calculator subject = new Calculator(); // Act
            var result = subject.ToString(); // Assert
            Assert.That(result, Does.Contain("Calculator"));
            Assert.That(result, Is.EqualTo("AdvancedNUnit.Calculator"));
            Assert.That(result, Is.EqualTo("advancednunit.calculator").IgnoreCase);
            Assert.That(result, Does.Not.Contain("Potato"));
            Assert.That(result, Does.StartWith("A"));
            Assert.That(result, Has.Length.EqualTo(24));
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public void CollectionContraintsExercise()
        {
            var trainers = new string[] { "Laura", "Joe", "Phil", "Neil", "Martin", "Cathy" };

            Assert.That(trainers, Has.Exactly(6).Items);
            Assert.That(trainers, Has.Exactly(2).EndWith("l"));
            Assert.That(trainers, Does.Contain("cathy").IgnoreCase);
            Assert.That(trainers, Has.Exactly(3).Contain("i").IgnoreCase);
        }

        [Test]
        public void RangeContraintsExercise()
        {
            var nums = new int[] { 4, 2, 6, 7, 1, 9 };

            Assert.That(8, Is.InRange(1, 10));
            Assert.That(nums, Is.All.InRange(1, 10));
            Assert.That(nums, Has.Exactly(3).InRange(1, 5));
        }
    }  
}