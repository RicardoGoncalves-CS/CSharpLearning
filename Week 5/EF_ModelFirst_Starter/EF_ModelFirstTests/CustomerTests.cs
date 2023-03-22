using EF_ModelFirst.Model;

namespace EF_ModelFirstTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // remove test entry in DB if present
            using (var db = new SouthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MANDA"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenANewCustomerIsAdded_TheNumberOfCustomersIncreasesBy1()
        {
            SouthwindContext context = new SouthwindContext();

            var initialLength = context.Customers.Count();

            Customer customer = new Customer();

            customer.CustomerId = "TEST1";
            customer.ContactName = "TEST1";
            customer.City = "TEST1";
            customer.PostalCode = "TEST1";
            customer.Country = "TEST1";

            context.Customers.Add(customer);
            context.SaveChanges();

            var finalLength = context.Customers.Count();

            Assert.That(finalLength, Is.EqualTo(initialLength + 1));
        }

        [Test]
        public void WhenANewCustomerIsAdded_TheirDetailsAreCorrect()
        {
            SouthwindContext context = new SouthwindContext();

            string id = string.Empty;
            string name = string.Empty;
            string city = string.Empty;
            string postcode = string.Empty;
            string country = string.Empty;

            var customer = context.Customers
                .Where(c => c.CustomerId == "TEST1");

            foreach(var c in customer)
            {
                id = c.CustomerId;
                name = c.ContactName;
                city = c.City;
                postcode = c.PostalCode;
                country = c.Country;
            };

            Assert.That(id, Is.EqualTo("TEST1"));
            Assert.That(name, Is.EqualTo("TEST1"));
            Assert.That(city, Is.EqualTo("TEST1"));
            Assert.That(postcode, Is.EqualTo("TEST1"));
            Assert.That(country, Is.EqualTo("TEST1"));
        }

        [Test]
        public void WhenRetrievingCustomers_CustomerListIsRightLength()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenRetrievingACustomer_ThatCustomerHasRightDetails()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenACustomerIsUpdated_TheTableDetailsUpdated()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenACustomerIsNotInTheDatabase_Update_ReturnsFalse()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenACustomerIsRemoved_TheNumberOfCustomersDecreasesBy1()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenACustomerIsRemoved_TheyAreNoLongerInTheDatabase()
        {
            Assert.Fail();
        }

        [Test]
        public void WhenACustomerIsNotInTheDatabase_Remove_ReturnsFalse()
        {
            Assert.Fail();
        }

        [TearDown]
        public void TearDown()
        {
            using (var db = new SouthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MANDA"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }
    }
}