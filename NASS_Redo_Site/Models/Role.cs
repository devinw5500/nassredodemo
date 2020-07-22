using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Role
    {
        public Role()
        {
            EmpRole = new HashSet<EmpRole>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PermissionsId { get; set; }

        public virtual Permissions Permissions { get; set; }
        public virtual ICollection<EmpRole> EmpRole { get; set; }
    }
}
