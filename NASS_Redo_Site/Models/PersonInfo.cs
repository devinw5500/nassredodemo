using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class PersonInfo
    {
        public PersonInfo()
        {
            PersonContact = new HashSet<PersonContact>();
            PersonSensitive = new HashSet<PersonSensitive>();
            TaxCollector = new HashSet<TaxCollector>();
        }

        public int PersonInfoId { get; set; }
        public int PersonId { get; set; }
        public int AddrId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }

        public virtual Address Addr { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<PersonContact> PersonContact { get; set; }
        public virtual ICollection<PersonSensitive> PersonSensitive { get; set; }
        public virtual ICollection<TaxCollector> TaxCollector { get; set; }
    }
}
