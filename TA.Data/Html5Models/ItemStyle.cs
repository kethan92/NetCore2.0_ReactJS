using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemStyle
    {
        public Guid ItemId { get; set; }
        public Guid StyleId { get; set; }

        public Item Item { get; set; }
        public Style Style { get; set; }
    }
}
