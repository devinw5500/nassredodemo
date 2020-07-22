using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class VendorType
    {
        public VendorType()
        {
            VendorDetails = new HashSet<VendorDetails>();
        }

        public int VendorTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<VendorDetails> VendorDetails { get; set; }
    }
}
