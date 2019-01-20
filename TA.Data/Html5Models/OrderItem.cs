using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            OrderItemShippingStatus = new HashSet<OrderItemShippingStatus>();
        }

        public Guid OrderId { get; set; }
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Item Item { get; set; }
        public Order Order { get; set; }
        public ICollection<OrderItemShippingStatus> OrderItemShippingStatus { get; set; }
    }
}
