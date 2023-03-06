namespace RomanNumeralsExercise;

public class Tests
{
    [TestCase(1, "I")]
    [TestCase(2110, "MMCX")]
    [TestCase(3999, "MMMCMXCIX")]
    public void GivenAnInteger_RomanNumerals_ReturnIntegerInRomanNumeral(int input, string expected)
    {
        string result = Program.RomanNumerals(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(-10)]
    [TestCase(0)]
    [TestCase(4000)]
    public void GivenAnInvalidInteger_RomanNumerals_ReturnArgumentException(int input)
    {
        Assert.That(() => Program.RomanNumerals(input), Throws.TypeOf<ArgumentException>());
    }
}