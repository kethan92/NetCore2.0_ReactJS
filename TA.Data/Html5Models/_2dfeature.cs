using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class _2dfeature
    {
        public _2dfeature()
        {
            Item2dfeature = new HashSet<Item2dfeature>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Item2dfeature> Item2dfeature { get; set; }
    }
}
