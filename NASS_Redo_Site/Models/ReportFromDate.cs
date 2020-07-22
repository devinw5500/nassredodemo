using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ReportFromDate
    {
        public ReportFromDate()
        {
            ReportDetails = new HashSet<ReportDetails>();
        }

        public int ReportFromDateId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ReportDetails> ReportDetails { get; set; }
    }
}
