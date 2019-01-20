using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemType
    {
        public Guid ItemId { get; set; }
        public Guid TypeId { get; set; }

        public Item Item { get; set; }
        public Type Type { get; set; }
    }
}
