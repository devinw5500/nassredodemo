using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ParcelId
    {
        public int ParcelId1 { get; set; }
        public string Parcel { get; set; }
        public int AddrId { get; set; }

        public virtual Address Addr { get; set; }
    }
}
