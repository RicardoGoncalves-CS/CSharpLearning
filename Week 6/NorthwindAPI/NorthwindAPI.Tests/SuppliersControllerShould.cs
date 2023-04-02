using Moq;
using NorthwindAPI.Controllers;
using NorthwindAPI.Models.DTO;
using NorthwindAPI.Models;
using NorthwindAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace NorthwindAPI.Tests;

internal class SuppliersControllerShould
{
    [Category("Happy Path")]
    [Category("GetSuppliers")]
    [Test]
    public async Task GetSuppliers_WhenThereAreSuppliers_ReturnsListOfSupplierDTOs()
    {
        var mockService = Mock.Of<INorthwindService<Supplier>>();
        List<Supplier> suppliers = new List<Supplier> { Mock.Of<Supplier>(s => s.Products == Mock.Of<List<Product>>()) };
        Mock
        .Get(mockService)
        .Setup(sc => sc.GetAllAsync().Result)
        .Returns(suppliers);


        var sut = new SuppliersController(mockService);
        var result = await sut.GetSuppliers();
        Assert.That(result.Value, Is.InstanceOf<IEnumerable<SupplierDTO>>());
    }

    [Category("Happy Path")]
    [Category("GetSupplier")]
    [Test]
    public async Task GetSupplier_WhenSupplierExists_ReturnsSupplierDTO()
    {
        var mockService = Mock.Of<INorthwindService<Supplier>>();
        var supplier = new Supplier { SupplierId = 1, CompanyName = "Mock Company", ContactName = "Ricardo" };
        Mock.Get(mockService)
            .Setup(s => s.GetAsync(1))
            .ReturnsAsync(supplier);

        var sut = new SuppliersController(mockService);
        var supplierDto = Utils.SupplierToDTO(supplier);

        var result = await sut.GetSupplier(1);

        Assert.That(result.Value!.GetType(), Is.EqualTo(typeof(SupplierDTO)));
        Assert.That(supplierDto.SupplierId, Is.EqualTo(supplier.SupplierId));
        Assert.That(supplierDto.CompanyName, Is.EqualTo(supplier.CompanyName));
        Assert.That(supplierDto.ContactName, Is.EqualTo(supplier.ContactName));
    }

    [Category("Sad Path")]
    [Category("GetSupplier")]
    [Test]
    public async Task GetSupplier_WhenSupplierDoesNotExist_ReturnsNotFound()
    {
        var mockService = Mock.Of<INorthwindService<Supplier>>();
        Mock.Get(mockService)
            .Setup(s => s.GetAsync(It.IsAny<int>()))
            .ReturnsAsync((Supplier?)null);

        var sut = new SuppliersController(mockService);

        var result = await sut.GetSupplier(1);

        Assert.That(result.Result, Is.InstanceOf<NotFoundResult>());
    }

    [Category("Happy Path")]
    [Category("GetProductsBySupplier")]
    [Test]
    public async Task GetProductsBySupplier_WhenSupplierExists_ReturnsListOfProductDTOs()
    {
        var mockService = Mock.Of<INorthwindService<Supplier>>();
        var sut = new SuppliersController(mockService);

        var supplier = new Supplier
        {
            SupplierId = 1,
            CompanyName = "Mock Company",
            Products =
            {
                new Product { ProductId = 1, ProductName = "Product 1" },
                new Product { ProductId = 2, ProductName = "Product 2" },
                new Product { ProductId = 3, ProductName = "Product 3" }
            }
        };

        Mock.Get(mockService)
            .Setup(s => s.GetAsync(1))
            .ReturnsAsync(supplier);
            
        var result = await sut.GetProductsBySupplier(1);

        Assert.IsNotNull(result);
        Assert.That(result.Value!.ToList().Count, Is.EqualTo(3));
    }

    [Category("Sad Path")]
    [Category("GetProductsBySupplier")]
    [Test]
    public async Task GetProductsBySupplier_WhenSupplierHasNoProducts_ReturnsNotFound()
    {
        var mockService = Mock.Of<INorthwindService<Supplier>>();
        var sut = new SuppliersController(mockService);

        var supplier = new Supplier
        {
            SupplierId = 1,
            CompanyName = "Mock Company",
            Products = { }
        };

        Mock.Get(mockService)
            .Setup(s => s.GetAsync(1))
            .ReturnsAsync(supplier);

        var result = await sut.GetProductsBySupplier(1);

        Assert.IsNull(result.Result);
        Assert.That(result.Value!.ToList().Count, Is.EqualTo(0));
    }

    [Category("Happy Path")]
    [Category("PostSupplier")]
    [Test]
    public async Task PostSupplier_WhenSupplierExists_CreatesSupplier()
    {
        var mockService = Mock.Of<INorthwindService<Supplier>>();
        var sut = new SuppliersController(mockService);

        var supplier = new Supplier
        {
            CompanyName = "Mock Company",
            ContactName = "Ricardo Goncalves",
            ContactTitle = "Accountant",
            Country = "USA",
            Products = 
            {
                new Product { ProductId = 1, ProductName = "Product 1" },
                new Product { ProductId = 2, ProductName = "Product 2" },
                new Product { ProductId = 3, ProductName = "Product 3" }
            }
        };

        Mock.Get(mockService)
            .Setup(s => s.CreateAsync(supplier))
            .ReturnsAsync(true);

        var result = await sut.PostSupplier(supplier);

        Assert.IsInstanceOf<CreatedAtActionResult>(result.Result);
        Assert.That(result, Is.TypeOf<ActionResult<SupplierDTO>>());
        Mock.Get(mockService).Verify(s => s.CreateAsync(supplier), Times.Once);
    }

    [Category("Sad Path")]
    [Category("PostSupplier")]
    [Test]
    public async Task PostSupplier_WhenSupplierDoesntExists_AddsSupplierToSupplierTable()
    {
        var mockService = Mock.Of<INorthwindService<Supplier>>();
        var sut = new SuppliersController(mockService);

        Supplier supplier = new Supplier { };

        Mock.Get(mockService)
            .Setup(s => s.CreateAsync(supplier))
            .ReturnsAsync(false);

        var result = await sut.PostSupplier(supplier);

        Assert.IsInstanceOf<ObjectResult>(result.Result);
        Assert.IsNull(result.Value);
        Mock.Get(mockService).Verify(s => s.CreateAsync(supplier), Times.Once);
    }

    [Category("Happy Path")]
    [Category("DeleteSupplier")]
    [Test]
    public async Task DeleteSupplier_WhenGivenIdOfExistingSupplier_DeletesSupplier()
    {
        var mockService = Mock.Of<INorthwindService<Supplier>>();
        var sut = new SuppliersController(mockService);

        var supplier = new Supplier { SupplierId = 1, CompanyName = "Mock Company", ContactName = "Ricardo" };

        int supplierId = 1;

        Mock.Get(mockService)
            .Setup(s => s.DeleteAsync(supplierId))
        .ReturnsAsync(true);

        var result = await sut.DeleteSupplier(supplierId);

        Assert.IsInstanceOf<NoContentResult>(result);
        Mock.Get(mockService).Verify(s => s.DeleteAsync(supplierId), Times.Once);
    }

    [Category("Happy Path")]
    [Category("PutSupplier")]
    [Test]
    public async Task PutSupplier_WhenSupplierExists_UpdatesSupplier()
    {
        var mockService = Mock.Of<INorthwindService<Supplier>>();
        var sut = new SuppliersController(mockService);

        var existingSupplier = new Supplier { SupplierId = 1, CompanyName = "Mock Company", ContactName = "Ricardo" };
        var updatedSupplier = new Supplier { SupplierId = 1, CompanyName = "Updated Company", ContactName = "John" };

        Mock.Get(mockService)
            .Setup(s => s.GetAsync(1))
            .ReturnsAsync(existingSupplier);

        Mock.Get(mockService)
            .Setup(s => s.UpdateAsync(1, updatedSupplier))
            .ReturnsAsync(true);

        var result = await sut.PutSupplier(1, updatedSupplier);

        Assert.IsInstanceOf<NoContentResult>(result);
        Mock.Get(mockService).Verify(s => s.UpdateAsync(1, updatedSupplier), Times.Once);
        
        Mock.Get(mockService)
            .Setup(s => s.GetAsync(1))
            .ReturnsAsync(updatedSupplier);

        var supplierResult = await sut.GetSupplier(1);

        Assert.That(updatedSupplier.CompanyName, Is.EqualTo(supplierResult.Value.CompanyName));
        Assert.That(updatedSupplier.ContactName, Is.EqualTo(supplierResult.Value.ContactName));
        Mock.Get(mockService).Verify(s => s.GetAsync(1), Times.Once);
    }

}