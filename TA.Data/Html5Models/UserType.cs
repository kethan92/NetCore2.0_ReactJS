using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class UserType
    {
        public UserType()
        {
            User = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }

        public ICollection<User> User { get; set; }
    }
}
