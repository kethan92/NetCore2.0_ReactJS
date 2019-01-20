using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class StoreBrand
    {
        public Guid StoreId { get; set; }
        public Guid BrandId { get; set; }

        public Brand Brand { get; set; }
        public Store Store { get; set; }
    }
}
