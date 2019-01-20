using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Continent
    {
        public Continent()
        {
            Country = new HashSet<Country>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public ICollection<Country> Country { get; set; }
    }
}
