using Microsoft.EntityFrameworkCore;
using NorthwindData;
using NorthwindData.Services;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindTests
{
    // Using InMemory to test CustomerService
    internal class CustomerServiceTests
    {
        private CustomerService _sut;
        private NorthwindContext _context;

        // To setup the in-memory database
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // We want to pass options
            var options = new DbContextOptionsBuilder<NorthwindContext>()
                .UseInMemoryDatabase("InMemoryDb")
                .Options;
            _context = new NorthwindContext(options);
            _sut = new CustomerService(_context);

            // Adding customers to the DB
            _context.Customers.Add(
                new Customer{
                    CustomerId = "WINDR",
                    ContactName = "Philip Windridge",
                    CompanyName = "Sparta Global",
                    City = "Birmingham"
                });

            _context.Customers.Add(
                new Customer
                {
                    CustomerId = "TOZER",
                    ContactName = "Laura Tozer",
                    CompanyName = "Sparta Global",
                    City = "London"
                });

            _context.SaveChanges();
        }

        [SetUp]
        public void SetUp()
        {
            // TODO
            // Reset the DB before every test
        }

        [Test]
        public void GivenAValidId_GetCustomerById_ReturnsTheCorrectCustomer()
        {
            var result = _sut.GetCustomerById("TOZER");
            Assert.That(result, Is.TypeOf<Customer>());
            Assert.That(result.ContactName, Is.EqualTo("Laura Tozer"));
            Assert.That(result.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(result.City, Is.EqualTo("London"));
        }

        [Test]
        public void PassingACustomerInstance_CreateCustomer_AddCustomerToDatabase()
        {
            var customer = new Customer
            {
                CustomerId = "BONDJ",
                ContactName = "James Bond",
                CompanyName = "MI6",
                City = "London"
            };

            _sut.CreateCustomer(customer);

            var checkCustomer = _sut.GetCustomerList().FirstOrDefault(c => c.CustomerId == "BONDJ");

            Assert.That(customer, Is.EqualTo(checkCustomer));
        }

        [Test]
        public void WhenUsingCustomerService_GetCustomerList_ReturnsTheCorrectList()
        {
            var listInDb = _sut.GetCustomerList();
            var listLength = _context.Customers.Count();

            Assert.That(listInDb.Count, Is.EqualTo(listLength));
            Assert.That(listInDb, Is.InstanceOf<List<Customer>>());
        }

        [Test]
        public void WhenRemovingCustomerThroughCustomerService_RemoveCustomer_RemovesCustomerFromTheTable()
        {
            _sut.RemoveCustomer(_sut.GetCustomerList().FirstOrDefault(c => c.CustomerId == "WINDR"));

            Assert.That(_sut.GetCustomerById("WINDR"), Is.Null);
        }
    }
}
