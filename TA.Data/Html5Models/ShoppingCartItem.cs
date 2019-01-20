using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ShoppingCartItem
    {
        public ShoppingCartItem()
        {
            ShoppingCartItemShippingStatus = new HashSet<ShoppingCartItemShippingStatus>();
        }

        public Guid ShoppingCartId { get; set; }
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }

        public Item Item { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public ICollection<ShoppingCartItemShippingStatus> ShoppingCartItemShippingStatus { get; set; }
    }
}
