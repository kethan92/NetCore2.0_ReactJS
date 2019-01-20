using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Brand
    {
        public Brand()
        {
            BrandBlackout = new HashSet<BrandBlackout>();
            Collection = new HashSet<Collection>();
            Item = new HashSet<Item>();
            StoreBrand = new HashSet<StoreBrand>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<BrandBlackout> BrandBlackout { get; set; }
        public ICollection<Collection> Collection { get; set; }
        public ICollection<Item> Item { get; set; }
        public ICollection<StoreBrand> StoreBrand { get; set; }
    }
}
