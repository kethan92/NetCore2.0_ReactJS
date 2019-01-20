using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Lookbook
    {
        public Lookbook()
        {
            LookbookItem = new HashSet<LookbookItem>();
            LookbookShared = new HashSet<LookbookShared>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }

        public User User { get; set; }
        public ICollection<LookbookItem> LookbookItem { get; set; }
        public ICollection<LookbookShared> LookbookShared { get; set; }
    }
}
