using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class DesignerTaus
    {
        public Guid UserId { get; set; }
        public string TausId { get; set; }
        public string TausName { get; set; }
        public string DesignerType { get; set; }
        public double? Rate { get; set; }
        public double? RateDefault { get; set; }
    }
}
