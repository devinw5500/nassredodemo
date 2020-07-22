using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            ReportOnVendor = new HashSet<ReportOnVendor>();
            VendorDetails = new HashSet<VendorDetails>();
        }

        public int VendorId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ReportOnVendor> ReportOnVendor { get; set; }
        public virtual ICollection<VendorDetails> VendorDetails { get; set; }
    }
}
