using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class CatalogRequest
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public bool? Currentcustomer { get; set; }
        public string Customertype { get; set; }
        public DateTime? Insertdate { get; set; }
        public string Comments { get; set; }
        public string Sendmailresult { get; set; }
        public string Style { get; set; }
        public string Base { get; set; }
        public string Arm { get; set; }
        public string Leg { get; set; }
        public string Back { get; set; }
        public string Store { get; set; }
        public bool? OptIn { get; set; }
        public bool? IsConfirm { get; set; }
        public Guid? ConfirmId { get; set; }
        public string Cushion { get; set; }
    }
}
