using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class County
    {
        public County()
        {
            Address = new HashSet<Address>();
            CityCounty = new HashSet<CityCounty>();
            ColInCounty = new HashSet<ColInCounty>();
            CountyNote = new HashSet<CountyNote>();
            CountyZip = new HashSet<CountyZip>();
            MunInCounty = new HashSet<MunInCounty>();
        }

        public int CountyId { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<CityCounty> CityCounty { get; set; }
        public virtual ICollection<ColInCounty> ColInCounty { get; set; }
        public virtual ICollection<CountyNote> CountyNote { get; set; }
        public virtual ICollection<CountyZip> CountyZip { get; set; }
        public virtual ICollection<MunInCounty> MunInCounty { get; set; }
    }
}
