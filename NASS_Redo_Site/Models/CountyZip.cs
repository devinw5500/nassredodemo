using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class CountyZip
    {
        public int CountyZipId { get; set; }
        public int CountyId { get; set; }
        public int Zipid { get; set; }

        public virtual County County { get; set; }
        public virtual Zip Zip { get; set; }
    }
}
