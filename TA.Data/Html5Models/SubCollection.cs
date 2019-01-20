using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class SubCollection
    {
        public Guid CollectionId { get; set; }
        public Guid? BrandId { get; set; }
        public Guid? ParentCollectionId { get; set; }

        public Collection Collection { get; set; }
    }
}
