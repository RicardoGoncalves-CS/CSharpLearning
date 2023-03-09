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
        Assert.AreEqual(20, v.Position);
        Assert.AreEqual("Moving along 2 times", result);
    }

    [Test]
    public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
    {
        Vehicle v = new Vehicle(5, 40);
        var result = v.Move();
        Assert.AreEqual(40, v.Position);
        Assert.AreEqual("Moving along", result);
    }

    [Test]
    public void WhenADefaultVehicleMovesThreeTimes_ReturnsAStringWithTheCorrectInformation()
    {
        Vehicle v = new Vehicle();
        var result = v.Move(3);
        Assert.AreEqual("Moving along 3 times", result);
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