using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class City
    {
        public City()
        {
            Address = new HashSet<Address>();
            CityCounty = new HashSet<CityCounty>();
            CityZip = new HashSet<CityZip>();
        }

        public int CityId { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<CityCounty> CityCounty { get; set; }
        public virtual ICollection<CityZip> CityZip { get; set; }
    }
}
