using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemKenoVideo
    {
        public Guid ItemId { get; set; }
        public Guid KenoVideoId { get; set; }

        public Item Item { get; set; }
        public KenoVideo KenoVideo { get; set; }
    }
}
