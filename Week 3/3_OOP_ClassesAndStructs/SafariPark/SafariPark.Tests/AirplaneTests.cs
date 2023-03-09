using SafariPark.App;
using NUnit.Framework;

namespace SafariPark.Tests;

public class AirplaneTests
{
    [TestCase("Moving along 3 times at an altitude of 500 metres.")]
    public void GivenAirplaneAscend500AndMove3_ReturnsExpectedString(string expected)
    {
        Airplane airplane = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        airplane.Ascend(500);

        string result = airplane.Move(3);

        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("Thank you for flying JetsRUs: SafariPark.App.Airplane altitude: 500")]
    public void GivenAirplaneAscend500_AirplaneToString_ReturnsExpectedString(string expected)
    {
        Airplane airplane = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        airplane.Ascend(500);

        string result = airplane.ToString();

        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("Moving along at an altitude of 300 metres.")]
    public void GivenAirplaneAscend500Descend200AneMoveWithoutInput_ReturnsExpectedString(string expected)
    {
        Airplane airplane = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        airplane.Ascend(500);
        airplane.Descend(200);

        string result = airplane.Move();

        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("Thank you for flying JetsRUs: SafariPark.App.Airplane altitude: 300")]
    public void GivenAirplaneAscend500AndDescend200_AirplaneToString_ReturnsExpectedString(string expected)
    {
        Airplane airplane = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        airplane.Ascend(500);
        airplane.Descend(200);

        string result = airplane.ToString();

        Assert.That(result, Is.EqualTo(expected));
    }
}