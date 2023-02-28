using UnitTestLab;

namespace UnitTestLabTest
{
    public class Classification_Tests
    {
        [TestCase(1)]
        [TestCase(4)]
        [TestCase(7)]
        public void GivenAge_AvailableClassifications_ReturnUFilmsAreAvailable(int input)
        {
            string expected = "U films are available.";

            string result = Program.AvailableClassifications(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(8)]
        [TestCase(9)]
        [TestCase(11)]
        public void GivenAge_AvailableClassifications_ReturnUPGFilmsAreAvailable(int input)
        {
            string expected = "U and PG films are available.";

            string result = Program.AvailableClassifications(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        public void GivenAge_AvailableClassifications_ReturnUPG12FilmsAreAvailable(int input)
        {
            string expected = "U, PG, 12A & 12 films are available.";

            string result = Program.AvailableClassifications(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(15)]
        [TestCase(16)]
        [TestCase(17)]
        public void GivenAge_AvailableClassifications_ReturnUPG1215FilmsAreAvailable(int input)
        {
            string expected = "U, PG, 12A, 12 & 15 films are available.";

            string result = Program.AvailableClassifications(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(18)]
        [TestCase(25)]
        [TestCase(45)]
        public void GivenAge_AvailableClassifications_ReturnAllFilmsAreAvailable(int input)
        {
            string expected = "All films are available.";

            string result = Program.AvailableClassifications(input);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}