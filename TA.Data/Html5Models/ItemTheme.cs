using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemTheme
    {
        public Guid ItemId { get; set; }
        public Guid ThemeId { get; set; }

        public Item Item { get; set; }
        public Theme Theme { get; set; }
    }
}
