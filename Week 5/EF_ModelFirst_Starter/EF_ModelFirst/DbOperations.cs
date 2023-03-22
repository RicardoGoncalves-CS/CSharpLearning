using EF_ModelFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst
{
    internal class DbOperations
    {
        static SouthwindContext context = new SouthwindContext();

        public static Customer Find(string id)
        {
            var c = context.Customers
                .Where(c => c.CustomerId == id)
                .FirstOrDefault();

            return c;
        }

        public static void List()
        {

            var customers = context.Customers;
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        public static void Add()
        {
            Customer customer = GatherCustomerInfo();
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public static void Update(string id)
        {
            Customer c = Find(id);

            Customer customer = GatherCustomerInfo();

            if (customer.CustomerId != string.Empty) c.CustomerId = customer.CustomerId;
            if (customer.ContactName != string.Empty) c.ContactName = customer.ContactName;
            if (customer.City != string.Empty) c.City = customer.City;
            if (customer.PostalCode != string.Empty) c.PostalCode = customer.PostalCode;
            if (customer.Country != string.Empty) c.Country = customer.Country;

            context.SaveChanges();
        }

        public static void Delete(string id)
        {
            Customer c = Find(id);

            context.Remove(c);
            context.SaveChanges();
        }

        public static Customer GatherCustomerInfo()
        {
            Customer customer = new Customer();

            Console.Write(">>> Customer ID: ");
            string id = Console.ReadLine();

            Console.Write(">>> Contact Name: ");
            string name = Console.ReadLine();

            Console.Write(">>> Customer City: ");
            string city = Console.ReadLine();

            Console.Write(">>> Customer PostCode: ");
            string postCode = Console.ReadLine();

            Console.Write(">>> Customer Country: ");
            string country = Console.ReadLine();

            customer.CustomerId = id;
            customer.ContactName = name;
            customer.City = city;
            customer.PostalCode = postCode;
            customer.Country = country;

            return customer;
        }
    }
}
