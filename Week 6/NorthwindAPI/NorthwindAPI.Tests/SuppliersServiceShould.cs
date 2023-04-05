using Microsoft.Extensions.Logging;
using Moq;
using NorthwindAPI.Data.Repositories;
using NorthwindAPI.Models;
using NorthwindAPI.Services;

namespace NorthwindAPI.Tests;

internal class SuppliersServiceShould
{
    [Category("Happy Path")]
    [Category("GetSuppliers")]
    [Test]
    public async Task GetAllAsync_WhenThereAreSuppliers_ReturnsListOfSuppliers()
    {
        var mockRepository = GetRepository();
        var mockLogger = GetLogger();
        List<Customer> suppliers = new List<Customer> { It.IsAny<Customer>() };
        Mock
        .Get(mockRepository)
        .Setup(sc => sc.GetAllAsync().Result)
        .Returns(suppliers);
        Mock
        .Get(mockRepository)
        .Setup(sc => sc.IsNull)
        .Returns(false);

        var _sut = new NorthwindService<Customer>(mockLogger, mockRepository);
        var result = await _sut.GetAllAsync();
        Assert.That(result, Is.InstanceOf<IEnumerable<Customer>>());
    }

    private static ILogger<INorthwindService<Customer>> GetLogger()
    {
        return Mock.Of<ILogger<INorthwindService<Customer>>>();
    }


    private static INorthwindRepository<Customer> GetRepository()
    {
        return Mock.Of<INorthwindRepository<Customer>>();
    }
}
