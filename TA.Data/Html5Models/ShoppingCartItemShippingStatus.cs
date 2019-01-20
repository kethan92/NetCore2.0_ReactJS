using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ShoppingCartItemShippingStatus
    {
        public Guid ShoppingCartId { get; set; }
        public Guid ItemId { get; set; }
        public Guid ShippingStatusId { get; set; }
        public int Quantity { get; set; }

        public ShippingStatus ShippingStatus { get; set; }
        public ShoppingCartItem ShoppingCartItem { get; set; }
    }
}
