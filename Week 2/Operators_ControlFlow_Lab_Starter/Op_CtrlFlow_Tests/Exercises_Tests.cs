using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Op_CtrlFlow;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        [TestCase(1, 2, false)]
        [TestCase(5, 10, false)]
        [TestCase(10, 10, false)]
        [TestCase(22, 11, true)]
        [TestCase(30, 10, true)]
        [TestCase(100, 50, true)]
        public void GivenTwoIntegers_MyMethod_ReturnsTrueIfBothAreDifferentAndTheRemainderOfTheirDivisionIs0AndFalseOtherwise(int num1, int num2, bool expected)
        {
            bool result = Exercises.MyMethod(num1, num2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void AverageOfTotalSumOfZero_ThrowsDivideByZeroException()
        {
            var myList = new List<int>() { 0, 0, 0, 0, 0 };
            Assert.That(() => Exercises.Average(myList), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void WhenListIsEmpty_Average_ThrowsDivideByZeroException()
        {
            var myList = new List<int>() {};
            Assert.That(() => Exercises.Average(myList), Throws.TypeOf<DivideByZeroException>());

            // Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(-5)]
        public void TicketTypeArgumentExceptionTest(int age)
        {
            Assert.That(() => Exercises.TicketType(age), Throws.TypeOf<ArgumentException>());
        }

        [TestCase(0, "Fail")]
        [TestCase(22, "Fail")]
        [TestCase(39, "Fail")]
        [TestCase(40, "Pass")]
        [TestCase(50, "Pass")]
        [TestCase(59, "Pass")]
        [TestCase(60, "Pass with Merit")]
        [TestCase(68, "Pass with Merit")]
        [TestCase(74, "Pass with Merit")]
        [TestCase(75, "Pass with Distinction")]
        [TestCase(87, "Pass with Distinction")]
        [TestCase(100, "Pass with Distinction")]
        public void GradeTest(int mark, string expected)
        {
            var result = Exercises.Grade(mark);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(101)]
        [TestCase(-1)]
        public void GradeArgumentExceptionTest(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Throws.TypeOf<ArgumentException>());
        }

        [TestCase(0, 200)]
        [TestCase(1, 100)]
        [TestCase(2, 50)]
        [TestCase(3, 50)]
        [TestCase(4, 20)]
        // [TestCase(5, -1)]
        public void GetScottishMaxWeddingNumbersTest(int covidLevel, int expected)
        {
            var result = Exercises.GetScottishMaxWeddingNumbers(covidLevel);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(-1)]
        [TestCase(5)]
        public void GetScottishMaxWeddingNumbersArgumentExceptionTest(int covidLevel)
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(covidLevel), Throws.TypeOf<ArgumentException>());
        }
    }
}
