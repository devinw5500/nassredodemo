using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ReportTypes
    {
        public ReportTypes()
        {
            TypeOfReport = new HashSet<TypeOfReport>();
        }

        public int ReportTypesId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TypeOfReport> TypeOfReport { get; set; }
    }
}
