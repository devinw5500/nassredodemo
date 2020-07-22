using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ColInSchool
    {
        public int ColInSchoolId { get; set; }
        public int TaxColChargeId { get; set; }
        public int SchoolId { get; set; }

        public virtual SchoolDistrict School { get; set; }
        public virtual TaxCollectorInChargeOf TaxColCharge { get; set; }
    }
}
