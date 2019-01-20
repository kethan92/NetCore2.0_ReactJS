using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemCentury
    {
        public Guid ItemId { get; set; }
        public Guid CenturyId { get; set; }

        public Century Century { get; set; }
        public Item Item { get; set; }
    }
}
