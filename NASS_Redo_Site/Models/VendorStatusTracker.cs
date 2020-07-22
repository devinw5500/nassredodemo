using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class VendorStatusTracker
    {
        public int VendorStatusTrackerId { get; set; }
        public int VendorDetailsId { get; set; }
        public int VendorStatusId { get; set; }

        public virtual VendorDetails VendorDetails { get; set; }
        public virtual VendorStatus VendorStatus { get; set; }
    }
}
