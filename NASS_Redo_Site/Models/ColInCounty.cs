using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ColInCounty
    {
        public int ColInCountyId { get; set; }
        public int TaxColChargeId { get; set; }
        public int CountyId { get; set; }

        public virtual County County { get; set; }
        public virtual TaxCollectorInChargeOf TaxColCharge { get; set; }
    }
}
