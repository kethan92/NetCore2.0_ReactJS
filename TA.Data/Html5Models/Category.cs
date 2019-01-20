using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Category
    {
        public Category()
        {
            Item = new HashSet<Item>();
            Type = new HashSet<Type>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        public ICollection<Item> Item { get; set; }
        public ICollection<Type> Type { get; set; }
    }
}
