using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Style
    {
        public Style()
        {
            ItemStyle = new HashSet<ItemStyle>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemStyle> ItemStyle { get; set; }
    }
}
