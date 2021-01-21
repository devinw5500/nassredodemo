using System;
using System.Collections.Generic;

namespace TaxSystemNASS.Models
{
    public partial class PersonalInfo
    {
        public PersonalInfo()
        {
            PersonInOrder = new HashSet<PersonInOrder>();
        }

        public int PersonalInfoId { get; set; }
        public string PersonalInfoGuid { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HashedSsn { get; set; }

        public virtual ICollection<PersonInOrder> PersonInOrder { get; set; }
    }
}
