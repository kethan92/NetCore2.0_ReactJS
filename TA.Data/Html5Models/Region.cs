using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Region
    {
        public Region()
        {
            City = new HashSet<City>();
        }

        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }
        public ICollection<City> City { get; set; }
    }
}
