using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class User
    {
        public User()
        {
            Dealer = new HashSet<Dealer>();
            Lookbook = new HashSet<Lookbook>();
            LookbookShared = new HashSet<LookbookShared>();
            SalesAssociate = new HashSet<SalesAssociate>();
        }

        public Guid Id { get; set; }
        public Guid UserTypeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool EmailVerified { get; set; }
        public bool? AccountEnabled { get; set; }
        public DateTime DateCreated { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Guid? CityId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }

        public City City { get; set; }
        public UserType UserType { get; set; }
        public ICollection<Dealer> Dealer { get; set; }
        public ICollection<Lookbook> Lookbook { get; set; }
        public ICollection<LookbookShared> LookbookShared { get; set; }
        public ICollection<SalesAssociate> SalesAssociate { get; set; }
    }
}
