using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Permissions
    {
        public Permissions()
        {
            ClientPerm = new HashSet<ClientPerm>();
            Role = new HashSet<Role>();
        }

        public int PermissionsId { get; set; }
        public bool CanChangeRoles { get; set; }
        public bool CanSeeAllOrders { get; set; }
        public bool CanChangeGroups { get; set; }
        public bool CanChangeOrganizations { get; set; }
        public bool InChargeOfGroup { get; set; }
        public bool InChargeOfOrganization { get; set; }
        public bool CanChangeUser { get; set; }
        public bool CanAssignOrders { get; set; }
        public bool CanChangeOrders { get; set; }
        public bool CanChangeProducts { get; set; }
        public bool CanCreateReport { get; set; }
        public bool CanCreateProduct { get; set; }
        public bool CanMessageUsers { get; set; }

        public virtual ICollection<ClientPerm> ClientPerm { get; set; }
        public virtual ICollection<Role> Role { get; set; }
    }
}
