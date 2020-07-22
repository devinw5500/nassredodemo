using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Group
    {
        public Group()
        {
            EmpGroup = new HashSet<EmpGroup>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EmpGroup> EmpGroup { get; set; }
    }
}
