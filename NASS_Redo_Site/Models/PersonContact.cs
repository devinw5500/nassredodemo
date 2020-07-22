using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class PersonContact
    {
        public PersonContact()
        {
            PersonEmail = new HashSet<PersonEmail>();
            PersonPhone = new HashSet<PersonPhone>();
        }

        public int PersonContactId { get; set; }
        public int PersonInfoId { get; set; }

        public virtual PersonInfo PersonInfo { get; set; }
        public virtual ICollection<PersonEmail> PersonEmail { get; set; }
        public virtual ICollection<PersonPhone> PersonPhone { get; set; }
    }
}
