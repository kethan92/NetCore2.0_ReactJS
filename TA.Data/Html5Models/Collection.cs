using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Collection
    {
        public Collection()
        {
            Item = new HashSet<Item>();
        }

        public Guid Id { get; set; }
        public Guid BrandId { get; set; }
        public string Name { get; set; }

        public Brand Brand { get; set; }
        public SubCollection SubCollection { get; set; }
        public ICollection<Item> Item { get; set; }
    }
}
