using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class VendorSensitive
    {
        public VendorSensitive()
        {
            VendorDetails = new HashSet<VendorDetails>();
        }

        public int VendorSensitiveId { get; set; }
        public string VendorTin { get; set; }

        public virtual ICollection<VendorDetails> VendorDetails { get; set; }
    }
}
