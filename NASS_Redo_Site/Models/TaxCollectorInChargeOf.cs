using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class TaxCollectorInChargeOf
    {
        public TaxCollectorInChargeOf()
        {
            ColInCounty = new HashSet<ColInCounty>();
            ColInMunicipality = new HashSet<ColInMunicipality>();
            ColInSchool = new HashSet<ColInSchool>();
        }

        public int TaxCollectorInChargeOfId { get; set; }
        public int TaxColInfoId { get; set; }

        public virtual TaxCollectorInfo TaxColInfo { get; set; }
        public virtual ICollection<ColInCounty> ColInCounty { get; set; }
        public virtual ICollection<ColInMunicipality> ColInMunicipality { get; set; }
        public virtual ICollection<ColInSchool> ColInSchool { get; set; }
    }
}
