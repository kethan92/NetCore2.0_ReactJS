using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class LookbookShared
    {
        public Guid Id { get; set; }
        public Guid FromUserId { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public Guid LookbookId { get; set; }
        public string ToName { get; set; }
        public string ToEmail { get; set; }
        public string Message { get; set; }
        public bool? IncludeNotes { get; set; }
        public DateTime DateCreated { get; set; }

        public User FromUser { get; set; }
        public Lookbook Lookbook { get; set; }
    }
}
