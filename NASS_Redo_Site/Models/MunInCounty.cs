using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class MunInCounty
    {
        public int MunInAddressId { get; set; }
        public int CountyId { get; set; }
        public int MunId { get; set; }

        public virtual County County { get; set; }
        public virtual Municipality Mun { get; set; }
    }
}
