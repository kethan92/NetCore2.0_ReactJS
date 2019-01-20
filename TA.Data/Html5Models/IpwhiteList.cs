using System;
using System.Collections.Generic;

namespace TA.Data
{
    public partial class IpwhiteList
    {
        public Guid Id { get; set; }
        public string Ipaddress { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
