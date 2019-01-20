using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class SalesAssociate
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public User User { get; set; }
        public SalesAssociateStore SalesAssociateStore { get; set; }
    }
}
