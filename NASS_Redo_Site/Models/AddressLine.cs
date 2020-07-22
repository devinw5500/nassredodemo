using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class AddressLine
    {
        public int AddressLineId { get; set; }
        public int AddrId { get; set; }
        public string AddressLine1 { get; set; }

        public virtual Address Addr { get; set; }
    }
}
