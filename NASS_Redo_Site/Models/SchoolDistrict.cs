using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class SchoolDistrict
    {
        public SchoolDistrict()
        {
            ColInSchool = new HashSet<ColInSchool>();
            SchoolInAddress = new HashSet<SchoolInAddress>();
        }

        public int SchoolDistrictId { get; set; }
        public string Name { get; set; }
        public int AddrId { get; set; }

        public virtual Address Addr { get; set; }
        public virtual ICollection<ColInSchool> ColInSchool { get; set; }
        public virtual ICollection<SchoolInAddress> SchoolInAddress { get; set; }
    }
}
