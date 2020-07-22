using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class PersonEmail
    {
        public int PersonEmailId { get; set; }
        public int PersonContactId { get; set; }
        public string Email { get; set; }
        public bool Primary { get; set; }

        public virtual PersonContact PersonContact { get; set; }
    }
}
