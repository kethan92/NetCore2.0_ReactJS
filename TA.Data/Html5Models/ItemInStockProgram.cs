using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemInStockProgram
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }

        public Item Item { get; set; }
    }
}
