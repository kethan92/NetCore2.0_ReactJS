using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Dealer
    {
        public Dealer()
        {
            DealerShippingAddress = new HashSet<DealerShippingAddress>();
            DealerStore = new HashSet<DealerStore>();
            Order = new HashSet<Order>();
            ShoppingCart = new HashSet<ShoppingCart>();
        }

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid? ExclusivityGroupId { get; set; }
        public Guid? BillingAddressId { get; set; }
        public Guid? DefaultShippingAddressId { get; set; }
        public bool ShowSkus { get; set; }
        public bool ShowPrice { get; set; }
        public bool ShowAddress { get; set; }

        public Address BillingAddress { get; set; }
        public Address DefaultShippingAddress { get; set; }
        public ExclusivityGroup ExclusivityGroup { get; set; }
        public User User { get; set; }
        public ICollection<DealerShippingAddress> DealerShippingAddress { get; set; }
        public ICollection<DealerStore> DealerStore { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<ShoppingCart> ShoppingCart { get; set; }
    }
}
