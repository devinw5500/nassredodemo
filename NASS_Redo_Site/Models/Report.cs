using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Report
    {
        public Report()
        {
            ReportDetails = new HashSet<ReportDetails>();
        }

        public int ReportId { get; set; }

        public virtual ICollection<ReportDetails> ReportDetails { get; set; }
    }
}
