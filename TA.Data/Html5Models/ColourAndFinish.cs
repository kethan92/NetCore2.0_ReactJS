using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ColourAndFinish
    {
        public ColourAndFinish()
        {
            ItemColourAndFinish = new HashSet<ItemColourAndFinish>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemColourAndFinish> ItemColourAndFinish { get; set; }
    }
}
