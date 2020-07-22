using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class CityZip
    {
        public int CityZipId { get; set; }
        public int CityId { get; set; }
        public int Zipid { get; set; }

        public virtual City City { get; set; }
        public virtual Zip Zip { get; set; }
    }
}
