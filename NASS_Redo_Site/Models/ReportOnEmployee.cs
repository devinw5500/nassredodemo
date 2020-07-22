using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ReportOnEmployee
    {
        public int ReportOnEmployeeId { get; set; }
        public int ReportDetailsId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ReportDetails ReportDetails { get; set; }
    }
}
