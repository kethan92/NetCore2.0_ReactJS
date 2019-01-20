using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class DealerShippingAddress
    {
        public Guid DealerId { get; set; }
        public Guid ShippingAddressId { get; set; }

        public Dealer Dealer { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
