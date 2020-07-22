using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ReportOnTaxCol
    {
        public int ReportOnTaxColId { get; set; }
        public int ReportDetailsId { get; set; }
        public int TaxCollectorId { get; set; }

        public virtual ReportDetails ReportDetails { get; set; }
        public virtual TaxCollector TaxCollector { get; set; }
    }
}
