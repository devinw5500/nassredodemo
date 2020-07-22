using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ReportOnVendor
    {
        public int ReportOnVendorId { get; set; }
        public int ReportDetailsId { get; set; }
        public int VendorId { get; set; }

        public virtual ReportDetails ReportDetails { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
