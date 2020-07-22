using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Workflow
    {
        public Workflow()
        {
            ProductOrderDetail = new HashSet<ProductOrderDetail>();
            WorkflowDetails = new HashSet<WorkflowDetails>();
            WorkflowGroupItem = new HashSet<WorkflowGroupItem>();
        }

        public int WorkflowId { get; set; }

        public virtual ICollection<ProductOrderDetail> ProductOrderDetail { get; set; }
        public virtual ICollection<WorkflowDetails> WorkflowDetails { get; set; }
        public virtual ICollection<WorkflowGroupItem> WorkflowGroupItem { get; set; }
    }
}
