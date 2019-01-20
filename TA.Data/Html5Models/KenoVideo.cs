using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class KenoVideo
    {
        public KenoVideo()
        {
            ItemKenoVideo = new HashSet<ItemKenoVideo>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ContentTitle { get; set; }
        public string ContentBody { get; set; }
        public string ContentVideoS7 { get; set; }

        public ICollection<ItemKenoVideo> ItemKenoVideo { get; set; }
    }
}
