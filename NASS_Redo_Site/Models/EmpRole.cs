using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class EmpRole
    {
        public int EmpRoleId { get; set; }
        public int RoleId { get; set; }
        public int EmpId { get; set; }

        public virtual Employee Emp { get; set; }
        public virtual Role Role { get; set; }
    }
}
