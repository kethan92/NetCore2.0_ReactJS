using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class ProcessAndTechnique
    {
        public ProcessAndTechnique()
        {
            ItemProcessAndTechnique = new HashSet<ItemProcessAndTechnique>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ContentTitle { get; set; }
        public string ContentBody { get; set; }
        public string ContentVideoS7 { get; set; }

        public ICollection<ItemProcessAndTechnique> ItemProcessAndTechnique { get; set; }
    }
}
