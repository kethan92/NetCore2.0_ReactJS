using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemGeography
    {
        public Guid ItemId { get; set; }
        public Guid GeographyId { get; set; }

        public Geography Geography { get; set; }
        public Item Item { get; set; }
    }
}
