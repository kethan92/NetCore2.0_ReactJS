using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemShippingStatus
    {
        public Guid ItemId { get; set; }
        public Guid ShippingStatusId { get; set; }
        public int Quantity { get; set; }

        public Item Item { get; set; }
        public ShippingStatus ShippingStatus { get; set; }
    }
}
