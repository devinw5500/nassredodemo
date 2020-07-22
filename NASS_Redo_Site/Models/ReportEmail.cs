using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ReportEmail
    {
        public int ReportEmailId { get; set; }
        public string Email { get; set; }
        public int ReportDetailsId { get; set; }

        public virtual ReportDetails ReportDetails { get; set; }
    }
}
