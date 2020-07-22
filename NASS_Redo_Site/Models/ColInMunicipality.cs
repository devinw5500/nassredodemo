using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ColInMunicipality
    {
        public int ColInMunicipalityId { get; set; }
        public int TaxColChargeId { get; set; }
        public int MunId { get; set; }

        public virtual Municipality Mun { get; set; }
        public virtual TaxCollectorInChargeOf TaxColCharge { get; set; }
    }
}
