using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Care
    {
        public Care()
        {
            ItemCare = new HashSet<ItemCare>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ContentTitle { get; set; }
        public string ContentBody { get; set; }
        public string ContentImageS7 { get; set; }

        public ICollection<ItemCare> ItemCare { get; set; }
    }
}
