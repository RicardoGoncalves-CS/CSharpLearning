using FizzBuzzApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    internal class FizzBuzzerShould
    {
        [Test]
        public void FizzBuzz_WhenGivenTheNumber1_Output1AsAString()
        {
            Assert.That(FizzBuzzer.FizzBuzz(1), Is.EqualTo("1"));
        }

        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(8, "8")]
        public void FizzBuzz_WhenGivenTheNumberNotDivisibleBy5Or3_ReturnItAsAString(int input, string expResult)
        {
            Assert.That(FizzBuzzer.FizzBuzz(input), Is.EqualTo(expResult));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void FizzBuzz_WhenGivenANumberDivisibleBy3_ReturnsFizz(int input)
        {
            Assert.That(FizzBuzzer.FizzBuzz(input), Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(100)]
        public void FizzBuzz_WhenGivenANumberDivisibleBy5_ReturnsBuzz(int input)
        {
            Assert.That(FizzBuzzer.FizzBuzz(input), Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(150)]
        [TestCase(1500)]
        public void FizzBuzz_WhenGivenANumberDivisibleBy15_ReturnsFizzBuzz(int input)
        {
            Assert.That(FizzBuzzer.FizzBuzz(input), Is.EqualTo("FizzBuzz"));
        }
    }
}
