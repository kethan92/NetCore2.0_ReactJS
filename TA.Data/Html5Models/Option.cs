using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Option
    {
        public Guid Id { get; set; }
        public Guid OptionGroupId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Filename { get; set; }

        public OptionGroup OptionGroup { get; set; }
    }
}
