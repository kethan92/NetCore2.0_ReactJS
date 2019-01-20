using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Address
    {
        public Address()
        {
            DealerBillingAddress = new HashSet<Dealer>();
            DealerDefaultShippingAddress = new HashSet<Dealer>();
            DealerShippingAddress = new HashSet<DealerShippingAddress>();
        }

        public Guid Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public Guid CityId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public City City { get; set; }
        public ICollection<Dealer> DealerBillingAddress { get; set; }
        public ICollection<Dealer> DealerDefaultShippingAddress { get; set; }
        public ICollection<DealerShippingAddress> DealerShippingAddress { get; set; }
    }
}
