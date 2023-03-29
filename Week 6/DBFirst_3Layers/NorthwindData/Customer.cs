using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindData
{
    public partial class Customer : IEquatable<Customer>
    {
        public Customer()
        {
            CustomerCustomerDemos = new HashSet<CustomerCustomerDemo>();
            Orders = new HashSet<Order>();
        }

        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Customer);
        }

        public bool Equals(Customer other)
        {
            return other is not null &&
                   CustomerId == other.CustomerId &&
                   CompanyName == other.CompanyName &&
                   ContactName == other.ContactName &&
                   ContactTitle == other.ContactTitle &&
                   Address == other.Address &&
                   City == other.City &&
                   Region == other.Region &&
                   PostalCode == other.PostalCode &&
                   Country == other.Country &&
                   Phone == other.Phone &&
                   Fax == other.Fax &&
                   EqualityComparer<ICollection<CustomerCustomerDemo>>.Default.Equals(CustomerCustomerDemos, other.CustomerCustomerDemos) &&
                   EqualityComparer<ICollection<Order>>.Default.Equals(Orders, other.Orders);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(CustomerId);
            hash.Add(CompanyName);
            hash.Add(ContactName);
            hash.Add(ContactTitle);
            hash.Add(Address);
            hash.Add(City);
            hash.Add(Region);
            hash.Add(PostalCode);
            hash.Add(Country);
            hash.Add(Phone);
            hash.Add(Fax);
            hash.Add(CustomerCustomerDemos);
            hash.Add(Orders);
            return hash.ToHashCode();
        }

        public static bool operator == (Customer left, Customer right)
        {
            return EqualityComparer<Customer>.Default.Equals(left, right);
        }

        public static bool operator != (Customer left, Customer right)
        {
            return !(left == right);
        }
    }
}
