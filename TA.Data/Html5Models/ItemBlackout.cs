using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemBlackout
    {
        public Guid ItemId { get; set; }
        public Guid CountryId { get; set; }

        public Country Country { get; set; }
        public Item Item { get; set; }
    }
}
