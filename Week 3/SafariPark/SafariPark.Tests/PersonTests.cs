using SafariPark.App;

namespace SafariPark.Tests;

public class PersonTests
{
    [TestCase("Cathy", "French", "Cathy French")]
    [TestCase("Peter", "Bellaby", "Peter Bellaby")]
    [TestCase("", "", " ")]
    public void FullName_WhenGivenFirstNameAndLastName_ReturnConcatenatedString(string fName, string lName, string expected)
    {
        var subject = new Person(fName, lName);
        var result = subject.FullName;
        Assert.That(result, Is.EqualTo(expected));
    }
}