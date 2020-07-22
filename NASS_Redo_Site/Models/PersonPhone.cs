using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class PersonPhone
    {
        public int PersonPhoneId { get; set; }
        public int PersonContactId { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public bool Primary { get; set; }

        public virtual PersonContact PersonContact { get; set; }
    }
}
