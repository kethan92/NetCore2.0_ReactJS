using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Material
    {
        public Material()
        {
            ItemPrimaryMaterial = new HashSet<Item>();
            ItemSecondaryMaterial = new HashSet<Item>();
            ItemTertiaryMaterial = new HashSet<Item>();
        }

        public Guid Id { get; set; }
        public Guid MaterialCategoryId { get; set; }
        public string Name { get; set; }

        public MaterialCategory MaterialCategory { get; set; }
        public ICollection<Item> ItemPrimaryMaterial { get; set; }
        public ICollection<Item> ItemSecondaryMaterial { get; set; }
        public ICollection<Item> ItemTertiaryMaterial { get; set; }
    }
}
