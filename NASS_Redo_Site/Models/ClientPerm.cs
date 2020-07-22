using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ClientPerm
    {
        public int ClientPermId { get; set; }
        public int PermissionsId { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Permissions Permissions { get; set; }
    }
}
