using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class OptionGroup
    {
        public OptionGroup()
        {
            ItemOptionGroup = new HashSet<Item>();
            ItemOptionGroup2 = new HashSet<Item>();
            ItemOptionGroup3 = new HashSet<Item>();
            Option = new HashSet<Option>();
        }

        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public string Name { get; set; }

        public ICollection<Item> ItemOptionGroup { get; set; }
        public ICollection<Item> ItemOptionGroup2 { get; set; }
        public ICollection<Item> ItemOptionGroup3 { get; set; }
        public ICollection<Option> Option { get; set; }
    }
}
