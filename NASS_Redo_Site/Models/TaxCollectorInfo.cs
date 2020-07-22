using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class TaxCollectorInfo
    {
        public TaxCollectorInfo()
        {
            TaxCollectorFee = new HashSet<TaxCollectorFee>();
            TaxCollectorInChargeOf = new HashSet<TaxCollectorInChargeOf>();
        }

        public int TaxCollectorInfoId { get; set; }
        public int TaxColId { get; set; }
        public string ReturnTime { get; set; }

        public virtual TaxCollector TaxCol { get; set; }
        public virtual ICollection<TaxCollectorFee> TaxCollectorFee { get; set; }
        public virtual ICollection<TaxCollectorInChargeOf> TaxCollectorInChargeOf { get; set; }
    }
}
