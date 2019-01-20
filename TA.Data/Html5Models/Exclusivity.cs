using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Exclusivity
    {
        public Guid ExclusivityGroupId { get; set; }
        public Guid ItemId { get; set; }

        public ExclusivityGroup ExclusivityGroup { get; set; }
        public Item Item { get; set; }
    }
}
