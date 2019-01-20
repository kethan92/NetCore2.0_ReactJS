using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class BrandBlackout
    {
        public Guid BrandId { get; set; }
        public Guid CountryId { get; set; }

        public Brand Brand { get; set; }
        public Country Country { get; set; }
    }
}
