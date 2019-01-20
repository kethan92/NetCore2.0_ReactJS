using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class _3dfeature
    {
        public _3dfeature()
        {
            Item3dfeature = new HashSet<Item3dfeature>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Item3dfeature> Item3dfeature { get; set; }
    }
}
