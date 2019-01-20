using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class Store
    {
        public Store()
        {
            DealerStore = new HashSet<DealerStore>();
            SalesAssociateStore = new HashSet<SalesAssociateStore>();
            StoreBrand = new HashSet<StoreBrand>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public double PriceMultiplier { get; set; }
        public bool? AccountEnabled { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsPreferred { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Guid CityId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public DateTime? DateModified { get; set; }

        public City City { get; set; }
        public ICollection<DealerStore> DealerStore { get; set; }
        public ICollection<SalesAssociateStore> SalesAssociateStore { get; set; }
        public ICollection<StoreBrand> StoreBrand { get; set; }
    }
}
