using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ExclusivityGroup
    {
        public ExclusivityGroup()
        {
            Dealer = new HashSet<Dealer>();
            Exclusivity = new HashSet<Exclusivity>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Dealer> Dealer { get; set; }
        public ICollection<Exclusivity> Exclusivity { get; set; }
    }
}
