using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class RelatedSkuForSpecialGroup
    {
        public Guid ItemId { get; set; }
        public string Sku { get; set; }

        public Item Item { get; set; }
    }
}
