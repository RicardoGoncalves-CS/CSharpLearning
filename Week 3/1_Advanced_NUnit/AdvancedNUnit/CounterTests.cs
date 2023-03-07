using NUnit.Framework;

namespace AdvancedNUnit
{
    [TestFixture]
    // [Ignore("Not using these tests yet")]
    public class CounterTests
    {
        // sut - system under test
        private Counter _sut; //  = new Counter(6);

        [SetUp]
        public void SetUp()
        {
           // _sut = new Counter(6);
           // This can be bad practice in certain scenarios where not every Test needs this SetUp
           // in this circumstances it is better to use a helper method and use it where it is needed; (helper method at the bottom)
        }

        [Test]
        public void Increment_IncreaseCountByOne()
        {
            CreateSut();
            _sut.Increment();
            Assert.That(_sut.Count, Is.EqualTo(7));
        }
        [Test]
        public void Decrement_DecreasesCountByOne()
        {
            CreateSut();
            _sut.Decrement();
            Assert.That(_sut.Count, Is.EqualTo(5));
        }

        // helper method
        private void CreateSut()
        {
            _sut = new Counter(6);
        }
    }
}
