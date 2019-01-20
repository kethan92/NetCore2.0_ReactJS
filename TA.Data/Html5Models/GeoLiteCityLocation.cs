using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class GeoLiteCityLocation
    {
        public int LocId { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string MetroCode { get; set; }
        public string AreaCode { get; set; }
    }
}
