using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Municipality
    {
        public Municipality()
        {
            ColInMunicipality = new HashSet<ColInMunicipality>();
            MunInCounty = new HashSet<MunInCounty>();
        }

        public int MunicipalityId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ColInMunicipality> ColInMunicipality { get; set; }
        public virtual ICollection<MunInCounty> MunInCounty { get; set; }
    }
}
