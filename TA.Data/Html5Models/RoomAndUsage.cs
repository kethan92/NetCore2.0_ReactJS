using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class RoomAndUsage
    {
        public RoomAndUsage()
        {
            Item = new HashSet<Item>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Item> Item { get; set; }
    }
}
