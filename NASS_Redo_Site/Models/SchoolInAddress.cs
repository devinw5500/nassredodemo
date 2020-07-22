using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class SchoolInAddress
    {
        public int SchoolInAddressId { get; set; }
        public int SchoolId { get; set; }
        public int AddrId { get; set; }

        public virtual Address Addr { get; set; }
        public virtual SchoolDistrict School { get; set; }
    }
}
