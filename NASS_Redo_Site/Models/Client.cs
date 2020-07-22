using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Client
    {
        public Client()
        {
            ClientOrg = new HashSet<ClientOrg>();
            ClientPerm = new HashSet<ClientPerm>();
            ReportOnClient = new HashSet<ReportOnClient>();
        }

        public int ClientId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ClientOrg> ClientOrg { get; set; }
        public virtual ICollection<ClientPerm> ClientPerm { get; set; }
        public virtual ICollection<ReportOnClient> ReportOnClient { get; set; }
    }
}
