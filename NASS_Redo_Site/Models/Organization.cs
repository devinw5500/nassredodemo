using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Organization
    {
        public Organization()
        {
            ClientOrg = new HashSet<ClientOrg>();
            ProdListOrganization = new HashSet<ProdListOrganization>();
            WorkflowGroup = new HashSet<WorkflowGroup>();
        }

        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public int AddrId { get; set; }

        public virtual ICollection<ClientOrg> ClientOrg { get; set; }
        public virtual ICollection<ProdListOrganization> ProdListOrganization { get; set; }
        public virtual ICollection<WorkflowGroup> WorkflowGroup { get; set; }
    }
}
