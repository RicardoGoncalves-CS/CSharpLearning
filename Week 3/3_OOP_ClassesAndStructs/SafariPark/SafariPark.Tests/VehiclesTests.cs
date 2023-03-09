using NUnit.Framework;
using SafariPark.App;

namespace SafariPark.Tests;

public class VehicleTests
{
    [Test]
    public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
    {
        Vehicle v = new Vehicle();
        var result = v.Move(2);
        Assert.That(v.Position, Is.EqualTo(20));
        Assert.That(result, Is.EqualTo("Moving along 2 times"));
    }

    [Test]
    public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
    {
        Vehicle v = new Vehicle(5, 40);
        var result = v.Move();
        Assert.That(v.Position, Is.EqualTo(40));
        Assert.That(result, Is.EqualTo("Moving along"));
    }

    [Test]
    public void WhenADefaultVehicleMovesThreeTimes_ReturnsAStringWithTheCorrectInformation()
    {
        Vehicle v = new Vehicle();
        var result = v.Move(3);
        Assert.That(result, Is.EqualTo("Moving along 3 times"));
    }

    [Test]
    public void WhenAVehicleHasNegativeNumberOfPassengers_ThrowsArgumentException()
    {
        // Arrange
        var vehicle = new Vehicle(4);
        int numPassengers = -1;         // Act and Assert
        Assert.Throws<ArgumentException>(() => vehicle.NumPassengers = numPassengers);
    }

    [Test]
    public void WhenAVehiclesHasMorePassengersThanItsCapacity_ThrowsArgumentException()
    {
        // Arrange
        var vehicle = new Vehicle(4);
        int numPassengers = 5;         // Assert
        Assert.Throws<ArgumentException>(() => vehicle.NumPassengers = numPassengers);
    }
}