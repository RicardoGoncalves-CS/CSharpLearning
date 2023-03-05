using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Week2_MiniProject
{
    public class Tests
    {
        private List<string> expected1 = new List<string> { "1: £50", "1: £10", "1: 50p", "1: 20p", "1: 5p", "1: 2p", "1: 1p" };
        private List<string> expected2 = new List<string> { "1: £20", "1: £10", "1: 50p", "1: 1p" };
        private List<string> expected3 = new List<string> { "2: £50", "1: £10", "1: £1", "1: 20p", "1: 2p", "1: 1p" };
        private List<string> expected4 = new List<string> { };

        [Test]
        public void GivenInput_MoneyProblem_ReturnsExpected1List()
        {
            double input = 60.78;
            List<string> result = Program.MoneyProblem(input);
            Assert.That(result, Is.EqualTo(expected1));
        }

        [Test]
        public void GivenInput_MoneyProblem_ReturnsExpected2List()
        {
            double input = 30.51;
            List<string> result = Program.MoneyProblem(input);
            Assert.That(result, Is.EqualTo(expected2));
        }

        [Test]
        public void GivenInput_MoneyProblem_ReturnsExpected3List()
        {
            double input = 111.23;
            List<string> result = Program.MoneyProblem(input);
            Assert.That(result, Is.EqualTo(expected3));
        }

        [Test]
        public void GivenInput_MoneyProblem_ReturnsExpected4List()
        {
            double input = 0;
            List<string> result = Program.MoneyProblem(input);
            Assert.That(result, Is.EqualTo(expected4));
        }

        [Test]
        public void GivenNegativeInput_MoneyProblem_ThrowsArgumenException()
        {
            double input = -10;
            Assert.That(() => Program.MoneyProblem(input), Throws.TypeOf<ArgumentException>());
        }
    }
}