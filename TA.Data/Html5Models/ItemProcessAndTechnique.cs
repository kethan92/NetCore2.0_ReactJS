using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ItemProcessAndTechnique
    {
        public Guid ItemId { get; set; }
        public Guid ProcessAndTechniqueId { get; set; }

        public Item Item { get; set; }
        public ProcessAndTechnique ProcessAndTechnique { get; set; }
    }
}
