using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class MaterialCategory
    {
        public MaterialCategory()
        {
            Material = new HashSet<Material>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Material> Material { get; set; }
    }
}
