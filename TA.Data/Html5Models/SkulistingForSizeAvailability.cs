using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class SkulistingForSizeAvailability
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public string Sku { get; set; }

        public Item Item { get; set; }
    }
}
