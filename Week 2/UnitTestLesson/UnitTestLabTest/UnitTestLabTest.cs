using UnitTestLab;

namespace UnitTestLabTest
{
    public class Classification_Tests
    {
        /*
         * Test Version 1
         * 
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
        */

        // Test Version 2

        [TestCase(1, "U films are available.")]
        [TestCase(4, "U films are available.")]
        [TestCase(7, "U films are available.")]
        public void GivenAge_AvailableClassifications_ReturnExpectedMessage(int input, string expected)
        {
            string result = Program.AvailableClassifications(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(-10)]
        [TestCase(0)]
        public void GivenNegativeAge_AvailableClassifications_ThrowsArgumenException(int input)
        {
            Assert.That(() => Program.AvailableClassifications(input), Throws.TypeOf<ArgumentException>());
        }
    }
}