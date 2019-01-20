using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Century
    {
        public Century()
        {
            ItemCentury = new HashSet<ItemCentury>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemCentury> ItemCentury { get; set; }
    }
}
