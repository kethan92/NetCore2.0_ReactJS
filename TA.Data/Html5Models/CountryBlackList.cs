using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class CountryBlackList
    {
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }

        public Country Country { get; set; }
    }
}
