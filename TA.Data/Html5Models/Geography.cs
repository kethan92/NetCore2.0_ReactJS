using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Geography
    {
        public Geography()
        {
            ItemGeography = new HashSet<ItemGeography>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemGeography> ItemGeography { get; set; }
    }
}
