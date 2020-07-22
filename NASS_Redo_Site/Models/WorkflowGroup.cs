using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class WorkflowGroup
    {
        public WorkflowGroup()
        {
            WorkflowGroupItem = new HashSet<WorkflowGroupItem>();
        }

        public int WorkflowGroupId { get; set; }
        public string Name { get; set; }
        public int OrgId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }

        public virtual Organization Org { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<WorkflowGroupItem> WorkflowGroupItem { get; set; }
    }
}
