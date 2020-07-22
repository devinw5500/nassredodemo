using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class FlowItemList
    {
        public FlowItemList()
        {
            ItemInList = new HashSet<ItemInList>();
        }

        public int FlowItemListId { get; set; }
        public int WorkflowDetailsId { get; set; }

        public virtual WorkflowDetails WorkflowDetails { get; set; }
        public virtual ICollection<ItemInList> ItemInList { get; set; }
    }
}
