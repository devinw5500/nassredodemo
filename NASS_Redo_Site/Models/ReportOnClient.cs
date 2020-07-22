using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ReportOnClient
    {
        public int ReportOnClientId { get; set; }
        public int ReportDetailsId { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual ReportDetails ReportDetails { get; set; }
    }
}
