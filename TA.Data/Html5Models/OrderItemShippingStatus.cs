using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class OrderItemShippingStatus
    {
        public Guid OrderId { get; set; }
        public Guid ItemId { get; set; }
        public Guid ShippingStatusId { get; set; }
        public int Quantity { get; set; }

        public OrderItem OrderItem { get; set; }
        public ShippingStatus ShippingStatus { get; set; }
    }
}
