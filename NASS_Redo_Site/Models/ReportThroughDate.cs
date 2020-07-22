using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ReportThroughDate
    {
        public ReportThroughDate()
        {
            ReportDetails = new HashSet<ReportDetails>();
        }

        public int ReportThroughDateId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ReportDetails> ReportDetails { get; set; }
    }
}
