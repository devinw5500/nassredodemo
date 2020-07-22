using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class PersonSensitive
    {
        public int PersonSensitiveId { get; set; }
        public int PersonInfoId { get; set; }
        public string HashedSsn { get; set; }

        public virtual PersonInfo PersonInfo { get; set; }
    }
}
