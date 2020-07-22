using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class VendorStatus
    {
        public VendorStatus()
        {
            VendorStatusTracker = new HashSet<VendorStatusTracker>();
        }

        public int VendorStatusId { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<VendorStatusTracker> VendorStatusTracker { get; set; }
    }
}
