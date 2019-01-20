using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ShoppingCart
    {
        public ShoppingCart()
        {
            ShoppingCartItem = new HashSet<ShoppingCartItem>();
        }

        public Guid Id { get; set; }
        public Guid DealerId { get; set; }
        public DateTime? DateOrderCreated { get; set; }

        public Dealer Dealer { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCartItem { get; set; }
    }
}
