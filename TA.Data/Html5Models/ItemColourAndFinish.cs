using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemColourAndFinish
    {
        public Guid ItemId { get; set; }
        public Guid ColourAndFinishId { get; set; }

        public ColourAndFinish ColourAndFinish { get; set; }
        public Item Item { get; set; }
    }
}
