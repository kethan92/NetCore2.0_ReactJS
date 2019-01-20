using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemCare
    {
        public Guid ItemId { get; set; }
        public Guid CareId { get; set; }

        public Care Care { get; set; }
        public Item Item { get; set; }
    }
}
