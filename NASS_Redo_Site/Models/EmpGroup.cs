using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class EmpGroup
    {
        public int EmpGroupId { get; set; }
        public int GroupId { get; set; }
        public int EmpId { get; set; }

        public virtual Employee Emp { get; set; }
        public virtual Group Group { get; set; }
    }
}
