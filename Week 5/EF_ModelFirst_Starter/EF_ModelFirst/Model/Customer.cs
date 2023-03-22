using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst.Model
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"ID: {CustomerId} | Contact Name: {ContactName} | City: {City} | PostCode: {PostalCode} | Country: {Country}";
        }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
