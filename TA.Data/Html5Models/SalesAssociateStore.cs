using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class SalesAssociateStore
    {
        public Guid SalesAssociateId { get; set; }
        public Guid StoreId { get; set; }
        public bool DealerApproved { get; set; }

        public SalesAssociate SalesAssociate { get; set; }
        public Store Store { get; set; }
    }
}
