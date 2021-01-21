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
        public string PersonalInfoGuid { get; set; } = null;
        public string FirstName { get; set; } = null;
        public string MiddleInitial { get; set; } = null;
        public string LastName { get; set; } = null;
        public DateTime? Dob { get; set; } = null;
        public string Email { get; set; } = null;
        public string Phone { get; set; } = null;
        public string Fax { get; set; } = null;
        public string HashedSsn { get; set; }

        public virtual ICollection<PersonInOrder> PersonInOrder { get; set; }
    }
}