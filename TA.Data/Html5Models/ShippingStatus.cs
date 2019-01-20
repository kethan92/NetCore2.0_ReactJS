using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ShippingStatus
    {
        public ShippingStatus()
        {
            ItemShippingStatus = new HashSet<ItemShippingStatus>();
            OrderItemShippingStatus = new HashSet<OrderItemShippingStatus>();
            ShoppingCartItemShippingStatus = new HashSet<ShoppingCartItemShippingStatus>();
        }

        public Guid Id { get; set; }
        public string DeliveryTime { get; set; }
        public string DeliveryState { get; set; }
        public int MinimumDelay { get; set; }

        public ICollection<ItemShippingStatus> ItemShippingStatus { get; set; }
        public ICollection<OrderItemShippingStatus> OrderItemShippingStatus { get; set; }
        public ICollection<ShoppingCartItemShippingStatus> ShoppingCartItemShippingStatus { get; set; }
    }
}
