using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Shape
    {
        public Shape()
        {
            ItemShape = new HashSet<ItemShape>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemShape> ItemShape { get; set; }
    }
}
