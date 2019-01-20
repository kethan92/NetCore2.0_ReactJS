using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemPriceLog
    {
        public string Sku { get; set; }
        public string Parent { get; set; }
        public decimal? Skuprice { get; set; }
        public decimal? LocalPrice { get; set; }
        public string LocalSource { get; set; }
        public DateTime? Datetime { get; set; }
        public string Region { get; set; }
        public Guid? BatchId { get; set; }
        public int ItemPriceLogId { get; set; }
    }
}
