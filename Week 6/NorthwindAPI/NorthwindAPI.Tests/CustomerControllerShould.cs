using Moq;
using NorthwindAPI.Controllers;
using NorthwindAPI.Models.DTO;
using NorthwindAPI.Models;
using NorthwindAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindAPI.Tests
{
    internal class CustomerControllerShould
    {
        [Category("Happy Path")]
        [Category("GetCustomers")]
        [Test]
        public async Task GetCustomers_WhenThereAreSupp_ReturnsListOfSupplierDTOs()
        {
            var mockService = Mock.Of<INorthwindService<Customer>>();
            List<Customer> customer = new List<Customer> { Mock.Of<Customer>(s => s.Products == Mock.Of<List<Customer>>()) };
            Mock
            .Get(mockService)
            .Setup(c => c.GetAllAsync().Result)
            .Returns(customer);


            var sut = new SuppliersController(mockService);
            var result = await sut.GetSuppliers();
            Assert.That(result.Value, Is.InstanceOf<IEnumerable<Customer>>());
        }
    }
}
