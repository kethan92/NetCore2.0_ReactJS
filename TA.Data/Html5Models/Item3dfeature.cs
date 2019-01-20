using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Item3dfeature
    {
        public Guid ItemId { get; set; }
        public Guid _3dfeatureId { get; set; }

        public Item Item { get; set; }
        public _3dfeature _3dfeature { get; set; }
    }
}
