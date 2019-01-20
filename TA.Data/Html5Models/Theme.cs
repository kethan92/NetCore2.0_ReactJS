using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Theme
    {
        public Theme()
        {
            ItemTheme = new HashSet<ItemTheme>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemTheme> ItemTheme { get; set; }
    }
}
