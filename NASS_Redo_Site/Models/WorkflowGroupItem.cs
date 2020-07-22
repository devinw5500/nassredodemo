using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class WorkflowGroupItem
    {
        public int WorkflowGroupItemId { get; set; }
        public int WorkflowId { get; set; }
        public int WorkflowGroupId { get; set; }

        public virtual Workflow Workflow { get; set; }
        public virtual WorkflowGroup WorkflowGroup { get; set; }
    }
}
