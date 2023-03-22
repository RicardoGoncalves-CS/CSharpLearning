using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF_ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SouthwindContext())
            {
                List<Customer> customersList = new List<Customer>()
                {
                    new Customer
                    {
                        CustomerId = "C1",
                        ContactName = "Paul Smith",
                        City = "London",
                        PostalCode = "1234"
                    },
                    new Customer
                    {
                        CustomerId = "C2",
                        ContactName = "Alan Grant",
                        City = "Manchester",
                        PostalCode = "4545"
                    },
                    new Customer
                    {
                        CustomerId = "C3",
                        ContactName = "William Wallace ",
                        City = "Edinbrough",
                        PostalCode = "9876"
                    },
                    new Customer
                    {
                        CustomerId = "C4",
                        ContactName = "Brandon Johnson",
                        City = "Leeds",
                        PostalCode = "5050"
                    },
                    new Customer
                    {
                        CustomerId = "C5",
                        ContactName = "Clarice Munchies",
                        City = "Birmingham",
                        PostalCode = "7841"
                    }

                };

                db.AddRange(customersList);
                db.SaveChanges();
            };
        }
    }
}

