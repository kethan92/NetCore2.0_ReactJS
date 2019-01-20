using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemShape
    {
        public Guid ItemId { get; set; }
        public Guid ShapeId { get; set; }

        public Item Item { get; set; }
        public Shape Shape { get; set; }
    }
}
