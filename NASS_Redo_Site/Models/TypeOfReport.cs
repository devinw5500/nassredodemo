using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class TypeOfReport
    {
        public int TypeOfReportId { get; set; }
        public int TypeId { get; set; }
        public int ReportDetailsId { get; set; }

        public virtual ReportDetails ReportDetails { get; set; }
        public virtual ReportTypes Type { get; set; }
    }
}
