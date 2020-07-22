using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ReportDateDetails
    {
        public int ReportDateDetailsId { get; set; }
        public int ReportDetailsId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ThroughDate { get; set; }

        public virtual ReportDetails ReportDetails { get; set; }
    }
}
