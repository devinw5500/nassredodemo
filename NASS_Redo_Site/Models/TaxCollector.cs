using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class TaxCollector
    {
        public TaxCollector()
        {
            ReportOnTaxCol = new HashSet<ReportOnTaxCol>();
            TaxCollectorInfo = new HashSet<TaxCollectorInfo>();
        }

        public int TaxCollectorId { get; set; }
        public int PersonId { get; set; }

        public virtual PersonInfo Person { get; set; }
        public virtual ICollection<ReportOnTaxCol> ReportOnTaxCol { get; set; }
        public virtual ICollection<TaxCollectorInfo> TaxCollectorInfo { get; set; }
    }
}
