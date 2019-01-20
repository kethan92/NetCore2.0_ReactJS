using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class RelatedItem
    {
        public Guid ItemId { get; set; }
        public Guid RelatedItemId { get; set; }

        public Item Item { get; set; }
        public Item RelatedItemNavigation { get; set; }
    }
}
