using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class City
    {
        public City()
        {
            Address = new HashSet<Address>();
            Order = new HashSet<Order>();
            Store = new HashSet<Store>();
            User = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public Guid RegionId { get; set; }
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int Population { get; set; }
        public string Timezone { get; set; }
        public decimal Gmtoffset { get; set; }

        public Region Region { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Store> Store { get; set; }
        public ICollection<User> User { get; set; }
    }
}
