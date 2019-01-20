using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class GeoLite2CityLocations
    {
        public int GeonameId { get; set; }
        public string ContinentCode { get; set; }
        public string ContinentName { get; set; }
        public string CountryIsoCode { get; set; }
        public string CountryName { get; set; }
        public double? SubdivisionIsoCode { get; set; }
        public string SubdivisionName { get; set; }
        public string CityName { get; set; }
        public string MetroCode { get; set; }
        public string TimeZone { get; set; }
    }
}
