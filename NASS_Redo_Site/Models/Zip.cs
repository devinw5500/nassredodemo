using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Zip
    {
        public Zip()
        {
            Address = new HashSet<Address>();
            CityZip = new HashSet<CityZip>();
            CountyZip = new HashSet<CountyZip>();
        }

        public int Zipid { get; set; }
        public string Zip1 { get; set; }
        public int StateId { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<CityZip> CityZip { get; set; }
        public virtual ICollection<CountyZip> CountyZip { get; set; }
    }
}
