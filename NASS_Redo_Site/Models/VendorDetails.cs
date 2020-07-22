using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class VendorDetails
    {
        public VendorDetails()
        {
            VendorStatusTracker = new HashSet<VendorStatusTracker>();
        }

        public int? VendorId { get; set; }
        public int VendorDetailsId { get; set; }
        public int VendorTypeId { get; set; }
        public int VendorSensitiveId { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual VendorSensitive VendorSensitive { get; set; }
        public virtual VendorType VendorType { get; set; }
        public virtual ICollection<VendorStatusTracker> VendorStatusTracker { get; set; }
    }
}
