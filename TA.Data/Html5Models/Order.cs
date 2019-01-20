using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Order
    {
        public Order()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public Guid Id { get; set; }
        public Guid DealerId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public Guid ShippingCityId { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingPhone { get; set; }
        public string ContainerReference { get; set; }
        public string ShippingInstructions { get; set; }

        public Dealer Dealer { get; set; }
        public City ShippingCity { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
