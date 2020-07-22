using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class WorkflowDetails
    {
        public WorkflowDetails()
        {
            FlowItemList = new HashSet<FlowItemList>();
        }

        public int WorkflowDetailsId { get; set; }
        public int WorkflowId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool Inactive { get; set; }

        public virtual User LastModifiedByNavigation { get; set; }
        public virtual Workflow Workflow { get; set; }
        public virtual ICollection<FlowItemList> FlowItemList { get; set; }
    }
}
