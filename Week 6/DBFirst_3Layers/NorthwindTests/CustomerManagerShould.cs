using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Moq;
using NorthwindBusiness;
using NorthwindData;
using NorthwindData.Services;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace NorthwindTests;

// Using MOQ in tests
internal class CustomerManagerShould
{
    private CustomerManager _sut;

    // Black Box Tests - State Tests
    [Test]
    public void BeAbleToBeConstructedUsingMoq()
    {
        // Constructing a Mock of type ICustomerService
        var mockCustomerService = new Mock<ICustomerService>();

        _sut = new CustomerManager(mockCustomerService.Object);

        Assert.That(_sut, Is.InstanceOf<CustomerManager>());
    }

    [Test]
    public void WhenCalledWithValidId_Update_ReturnsTrue()
    {
        // Arrange
        var mockCustomerService = new Mock<ICustomerService>();
        var originalCustomer = new Customer
        {
            CustomerId = "ROCK"
        };
        mockCustomerService.Setup(
            cs => cs.GetCustomerById("ROCK"))
                .Returns(originalCustomer);



        _sut = new CustomerManager(mockCustomerService.Object);



        // Act
        var result = _sut.Update(
            "ROCK", It.IsAny<string>(), It.IsAny<string>(),
            It.IsAny<string>(), It.IsAny<string>());

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void WhenCalledWithValidIdAndValues_Update_CorrectlyChangesValues()
    {
        // Arrange
        var mockCustomerService = new Mock<ICustomerService>();
        var originalCustomer = new Customer()
        {
            CustomerId = "ROCK",
            ContactName = "Rocky Raccoon",
            CompanyName = "Zoo UK",
            City = "Telford"
        };
        mockCustomerService.Setup(
        cs => cs.GetCustomerById("ROCK"))
            .Returns(originalCustomer);

        _sut = new CustomerManager(mockCustomerService.Object);

        // Act
        _sut.Update("ROCK", "Rocky Raccoon", "UK", "Chester", null);



        // Assert
        Assert.That(
        _sut.SelectedCustomer.ContactName,
        Is.EqualTo("Rocky Raccoon"));
        Assert.That(
        _sut.SelectedCustomer.CompanyName,
        Is.EqualTo("Zoo UK"));
        Assert.That(
        _sut.SelectedCustomer.Country,
        Is.EqualTo("UK"));
        Assert.That(
        _sut.SelectedCustomer.City,
        Is.EqualTo("Chester"));
    }


    [Test]
    public void WhenCalledWithInvalidId_Update_ReturnsFalse()
    {
        // Arrange
        var mockCustomerService = new Mock<ICustomerService>();

        mockCustomerService.Setup(
            cs => cs.GetCustomerById("ROCK"))
                .Returns((Customer)null);

        _sut = new CustomerManager(mockCustomerService.Object);
        // Act
        var result = _sut.Update(
            "ROCK", It.IsAny<string>(), It.IsAny<string>(),
            It.IsAny<string>(), It.IsAny<string>());

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void WhenCalledWithInvalidId_Update_DoesNotChangeTheSelectedCustomer()
    {
        // Arrange
        var mockCustomerService = new Mock<ICustomerService>();



        mockCustomerService.Setup(
            cs => cs.GetCustomerById("ROCK"))
                .Returns((Customer)null);



        var originalCustomer = new Customer()
        {
            CustomerId = "ROCK",
            ContactName = "Rocky Raccoon",
            CompanyName = "Zoo UK",
            City = "Telford"
        };



        _sut = new CustomerManager(mockCustomerService.Object);
        _sut.SelectedCustomer = originalCustomer;



        // Act
        _sut.Update("ROCK", "Rocky Raccoon", "UK", "Chester", null);



        // Assert that SelectedCustomer is unchanged
        Assert.That(
        _sut.SelectedCustomer.ContactName,
        Is.EqualTo("Rocky Raccoon"));
        Assert.That(
        _sut.SelectedCustomer.CompanyName,
        Is.EqualTo("Zoo UK"));
        Assert.That(
        _sut.SelectedCustomer.Country,
        Is.EqualTo(null));
        Assert.That(
        _sut.SelectedCustomer.City,
        Is.EqualTo("Telford"));
    }

    [Test]
    public void WhenADatabaseExceptionIsThrownWhileUpdating_Update_ReturnsFalse()
    {
        // Arrange
        var mockCustomerService = new Mock<ICustomerService>();



        mockCustomerService.Setup(
            cs => cs.GetCustomerById(
                It.IsAny<string>()))
                .Returns(new Customer());



        mockCustomerService.Setup(
            cs => cs.SaveCustomerChanges())
                .Throws<DbUpdateConcurrencyException>();



        _sut = new CustomerManager(mockCustomerService.Object);



        // Act
        var result = _sut.Update(
            "ROCK", It.IsAny<string>(), It.IsAny<string>(),
            It.IsAny<string>(), It.IsAny<string>());



        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void WhenADatabaseExceptionIsThrownWhileUpdating_Update_DoesNotChangeSelectedCustomer()
    {
        // Arrange
        var mockCustomerService = new Mock<ICustomerService>();



        mockCustomerService.Setup(
            cs => cs.GetCustomerById(
                It.IsAny<string>()))
                .Returns(new Customer());



        mockCustomerService.Setup(
            cs => cs.SaveCustomerChanges())
                .Throws<DbUpdateConcurrencyException>();



        var originalCustomer = new Customer()
        {
            CustomerId = "ROCK",
            ContactName = "Rocky Raccoon",
            CompanyName = "Zoo UK",
            City = "Telford"
        };



        _sut = new CustomerManager(mockCustomerService.Object);
        _sut.SelectedCustomer = originalCustomer;
        // Act
        _sut.Update("ROCK", "Rocky Raccoon", "UK", "Chester", null);



        // Assert
        Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Rocky Raccoon"));
        Assert.That(_sut.SelectedCustomer.CompanyName, Is.EqualTo("Zoo UK"));
        Assert.That(_sut.SelectedCustomer.Country, Is.EqualTo(null));
        Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Telford"));
    }

    [Test]
    public void WhenDeleteExistentCustomer_ReturnsTrue()
    {
        // Arrange
        var mockCustomerService = new Mock<ICustomerService>();

        var originalCustomer = new Customer
        {
            CustomerId = "ROCK"
        };

        mockCustomerService.Setup(
            cs => cs.GetCustomerById("ROCK"))
                .Returns(originalCustomer);

        _sut = new CustomerManager(mockCustomerService.Object);

        // Act
        var result = _sut.Delete("ROCK");

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void WhenDeleteInexistentCustomer_ReturnsFalse()
    {
        // Arrange
        var mockCustomerService = new Mock<ICustomerService>();

        mockCustomerService.Setup(
            cs => cs.GetCustomerById("ROCK"))
                .Returns((Customer)null);

        _sut = new CustomerManager(mockCustomerService.Object);

        // Act
        var result = _sut.Delete("ROCK");

        // Assert
        Assert.That(result, Is.False);
    }

    // Behaviour Testing - White Box Testing
    [Test]
    public void WhenUpdateIsCalledWithValidId_SaveCustomerChanges_IsCalledOnce()
    {
        // Arrange
        var mockCustomerService = new Mock<ICustomerService>();
        mockCustomerService.Setup(
            cs => cs.GetCustomerById("ROCK"))
                .Returns(new Customer());



        _sut = new CustomerManager(mockCustomerService.Object);



        // Act
        var result = _sut.Update(
            "ROCK", It.IsAny<string>(), It.IsAny<string>(),
            It.IsAny<string>(), It.IsAny<string>());



        // Assert
        mockCustomerService.Verify(
            cs => cs.SaveCustomerChanges(),
            Times.Once);
    }

    [Test]
    public void LetsSeeWhatHappens_WhenUpdateIsCalled_IfAllInvocationsArentSetUp()
    {
        // Arrange
        var mockCustomerService = new Mock<ICustomerService>(MockBehavior.Strict);
        mockCustomerService.Setup(
            cs => cs.GetCustomerById(It.IsAny<string>()))
            .Returns(new Customer());
        mockCustomerService.Setup(cs => cs.SaveCustomerChanges());
        _sut = new CustomerManager(mockCustomerService.Object);



        // Act
        var result = _sut.Update(
            "ROCK", It.IsAny<string>(), It.IsAny<string>(),
            It.IsAny<string>(), It.IsAny<string>());



        // Assert
        Assert.That(result);
    }

    // TASK
    // Use stubs to verify that `RetrieveAll` and `SetSelectedCustomer` methods work as expected.
    // Write a behavior-based test to verify that that the `CustomerManager` `Create` and `Delete` methods call the expected `CustomerService` methods.
    [Test]
    public void RetrieveAllStub_NeedABetterName()
    {
        // Arrange
        var mockCustomerService = new Mock<ICustomerService>();

        var listUnderTest = new List<Customer>();
        {
            new Customer
            {
                CustomerId = "TOZER",
                ContactName = "Laura Tozer",
                CompanyName = "Sparta Global",
                City = "London"
            };
            new Customer
            {
                CustomerId = "ROCK",
                ContactName = "Rocky Raccoon",
                CompanyName = "Zoo UK",
                City = "Telford"
            };
        };

        mockCustomerService.Setup(
            cs => cs.GetCustomerList())
                .Returns(listUnderTest);

        _sut = new CustomerManager(mockCustomerService.Object);

        _sut.Create("TOZER", "Laura Tozer", "Sparta Global", "London");
        _sut.Create("ROCK", "Rocky Raccoon", "Zoo UK", "Telford");

        // Act

        var result = _sut.RetrieveAll();

        // Assert
        Assert.That(result, Is.EqualTo(listUnderTest));
    }

    [Test]
    public void RetrieveAllBehaviour_NeedABetterName()
    {
        var mockCustomerService = new Mock<ICustomerService>();
        _sut = new CustomerManager(mockCustomerService.Object);

        _sut.RetrieveAll();

        mockCustomerService.Verify(
            cs => cs.GetCustomerList(),
            Times.Once);
    }

    [Test]
    public void SetSelectCustomerStub_NeedABetterName()
    {
        var mockCustomerService = new Mock<ICustomerService>();
        _sut = new CustomerManager(mockCustomerService.Object);

        var o = new Customer
        {
            CustomerId = "SETCUST"
        };
            
        _sut.SetSelectedCustomer(o);

        var result = _sut.SelectedCustomer;

        Assert.That(result, Is.EqualTo(o));
    }





    [Test]
    public void TestMethod()
    {
        var mock = new Mock<ICustomerService>();

        mock.Setup(m => m.GetCustomerById("ALFKI")).Returns(new Customer());

        _sut = new CustomerManager(mock.Object);

        var result = _sut.Delete("ALFKI");

        Assert.That(result, Is.True);
    }
}