using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class LookbookItem
    {
        public Guid LookbookId { get; set; }
        public Guid ItemId { get; set; }
        public string Note { get; set; }
        public DateTime DateAdded { get; set; }

        public Item Item { get; set; }
        public Lookbook Lookbook { get; set; }
    }
}
