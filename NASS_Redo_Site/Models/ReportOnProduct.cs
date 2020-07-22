using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ReportOnProduct
    {
        public int ReportOnProductId { get; set; }
        public int ReportDetailsId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ReportDetails ReportDetails { get; set; }
    }
}
