using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class TaxCollectorFee
    {
        public int TaxCollectorFeeId { get; set; }
        public int TaxColInfoId { get; set; }
        public decimal Fee { get; set; }
        public string For { get; set; }

        public virtual TaxCollectorInfo TaxColInfo { get; set; }
    }
}
