using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Type
    {
        public Type()
        {
            ItemType = new HashSet<ItemType>();
        }

        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }

        public Category Category { get; set; }
        public ICollection<ItemType> ItemType { get; set; }
    }
}
