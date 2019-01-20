using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class DealerStore
    {
        public Guid DealerId { get; set; }
        public Guid StoreId { get; set; }

        public Dealer Dealer { get; set; }
        public Store Store { get; set; }
    }
}
