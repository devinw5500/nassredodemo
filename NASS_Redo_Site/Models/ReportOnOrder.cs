using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ReportOnOrder
    {
        public int ReportOnOrderId { get; set; }
        public int ReportDetailsId { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual ReportDetails ReportDetails { get; set; }
    }
}
