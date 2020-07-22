using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class CityCounty
    {
        public int CityCountyId { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }

        public virtual City City { get; set; }
        public virtual County County { get; set; }
    }
}
