using UnitTestApp;

namespace UnitTestTest
{
    public class Tests
    {
        /*
        [SetUp]
        public void Setup()
        {
        }
        */

        [Test]
        public void Given5_MyMethod_ReturnGoodMorning()
        {
            // 3 A's of Unit Testing

            // Arrange
            int input = 5;
            string expected = "Good morning!";

            // Act
            string result = Program.MyMethod(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        // Testing the Equivalence partition 
        [Test]
        public void Given8_MyMethod_ReturnGoodMorning()
        {
            int input = 8;
            string expected = "Good morning!";

            string result = Program.MyMethod(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Given11_MyMethod_ReturnGoodMorning()
        {
            int input = 11;
            string expected = "Good morning!";

            string result = Program.MyMethod(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Given12_MyMethod_ReturnGoodMorning()
        {
            int input = 12;
            string expected = "Good afternoon!";

            string result = Program.MyMethod(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Given16_MyMethod_ReturnGoodMorning()
        {
            int input = 16;
            string expected = "Good afternoon!";

            string result = Program.MyMethod(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Given18_MyMethod_ReturnGoodMorning()
        {
            int input = 12;
            string expected = "Good afternoon!";

            string result = Program.MyMethod(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Given19_MyMethod_ReturnGoodMorning()
        {
            int input = 19;
            string expected = "Good evening!";

            string result = Program.MyMethod(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Given21_MyMethod_ReturnGoodMorning()
        {
            int input = 21;
            string expected = "Good evening!";

            string result = Program.MyMethod(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Given23_MyMethod_ReturnGoodMorning()
        {
            int input = 23;
            string expected = "Good evening!";

            string result = Program.MyMethod(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Given0_MyMethod_ReturnGoodMorning()
        {
            int input = 0;
            string expected = "Good evening!";

            string result = Program.MyMethod(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Given3_MyMethod_ReturnGoodMorning()
        {
            int input = 3;
            string expected = "Good evening!";

            string result = Program.MyMethod(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Given4_MyMethod_ReturnGoodMorning()
        {
            int input = 4;
            string expected = "Good evening!";

            string result = Program.MyMethod(input);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}