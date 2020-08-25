using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class State
    {
        public State()
        {
            City = new HashSet<City>();
            County = new HashSet<County>();
            Municipality = new HashSet<Municipality>();
            Zip = new HashSet<Zip>();
        }

        public int StateId { get; set; }
        public string Abbreviation { get; set; }
        public string Name { get; set; }

        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<County> County { get; set; }
        public virtual ICollection<Municipality> Municipality { get; set; }
        public virtual ICollection<Zip> Zip { get; set; }
    }
}
