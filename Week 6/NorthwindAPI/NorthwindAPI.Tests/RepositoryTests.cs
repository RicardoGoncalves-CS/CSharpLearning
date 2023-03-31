using NorthwindAPI.Data.Repositories;
using NorthwindAPI.Data;
using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Models;
using System.Collections.Generic;

namespace NorthwindAPI.Tests
{
    internal class RepositoryTests
    {
        private NorthwindContext _context;
        private SupplierRepository _sut;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            var options = new DbContextOptionsBuilder<NorthwindContext>()
            .UseInMemoryDatabase("NorthwindDB").Options;
            _context = new NorthwindContext(options);



            _sut = new SupplierRepository(_context);
        }

        [SetUp]
        public void SetUp()
        {
            if (_context.Suppliers != null)
            {
                _context.Suppliers.RemoveRange(_context.Suppliers);
            }



            _context.Suppliers!.AddRange(
            new List<Supplier>
            {
                 new Supplier
                 {
                 SupplierId = 1,
                 CompanyName = "Sparta Global",
                 City = "Birmingham",
                 Country = "UK",
                 ContactName = "Nish Mandal",
                 ContactTitle = "Manager"
                 },
                 new Supplier {
                 SupplierId = 2,
                 CompanyName = "Nintendo",
                 City = "Tokyo",
                 Country = "Japan",
                 ContactName = "Shigeru Miyamoto",
                 ContactTitle = "CEO"
                 }
            });
            _context.SaveChanges();
        }

        [Category("Happy Path")]
        [Category("FindAsync")]
        [Test]
        public void FindAsync_GivenValidID_ReturnsCorrectSupplier()
        {
            var result = _sut.FindAsync(1).Result;
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<Supplier>());
            Assert.That(result.CompanyName, Is.EqualTo("Sparta Global"));
        }

        [Category("Sad Path")]
        [Category("FindAsync")]
        [Test]
        public void FindAsync_GivenInvalidID_ReturnsCorrectSupplier()
        {
            var result = _sut.FindAsync(3).Result;
            Assert.That(result, Is.Null);
        }

        [Category("Happy Path")]
        [Category("GetAllAsync")]
        [Test]
        public void GetAllAsync_GivenValidID_ReturnsListOfSuppliers()
        {
            var result = _sut.GetAllAsync().Result;
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<List<Supplier>>());
        }

        [Category("Happy Path")]
        [Category("Remove")]
        [Test]
        public void Remove_GivenValidID_DeletesEntity()
        {
            var toRemove = _sut.FindAsync(1).Result;
            
            _sut.Remove(toRemove!);
            _sut.SaveAsync();

            var deleted = _sut.FindAsync(1).Result;

            Assert.That(deleted, Is.Null);
        }

        [Category("Happy Path")]
        [Category("Add")]
        [Test]
        public void Add_GivenValidParameters_AddsEntity()
        { 
            Supplier sup = new Supplier 
            {
                SupplierId = 3,
                CompanyName = "Wavy Wines",
                City = "London",
                Country = "UK",
                ContactName = "Marcos Smith",
                ContactTitle = "Manager"
            };

            _sut.Add(sup);
            _sut.SaveAsync();

            var result = _sut.FindAsync(3).Result;

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<Supplier>());
            Assert.That(result.ContactName, Is.EqualTo("Marcos Smith"));
        }
    }
}
