using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Country
    {
        public Country()
        {
            BrandBlackout = new HashSet<BrandBlackout>();
            CountryBlackList = new HashSet<CountryBlackList>();
            ItemBlackout = new HashSet<ItemBlackout>();
            Region = new HashSet<Region>();
        }

        public Guid Id { get; set; }
        public Guid ContinentId { get; set; }
        public string Name { get; set; }
        public string Iso { get; set; }
        public string Iso3 { get; set; }
        public int Isonumeric { get; set; }
        public string Fips { get; set; }
        public string Capital { get; set; }
        public int AreaSqrKm { get; set; }
        public int Population { get; set; }
        public string Continent { get; set; }
        public string Tld { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string Phone { get; set; }
        public string PostalCodeFormat { get; set; }
        public string PostalCodeRegex { get; set; }
        public string Languages { get; set; }

        public Continent ContinentNavigation { get; set; }
        public ICollection<BrandBlackout> BrandBlackout { get; set; }
        public ICollection<CountryBlackList> CountryBlackList { get; set; }
        public ICollection<ItemBlackout> ItemBlackout { get; set; }
        public ICollection<Region> Region { get; set; }
    }
}
