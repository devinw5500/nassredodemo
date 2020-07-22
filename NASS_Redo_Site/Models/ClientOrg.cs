using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ClientOrg
    {
        public int ClientOrgId { get; set; }
        public int OrgId { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Organization Org { get; set; }
    }
}
