using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ItemInList
    {
        public int ItemInListId { get; set; }
        public int FlowItemListId { get; set; }
        public int FlowItemId { get; set; }

        public virtual FlowItem FlowItem { get; set; }
        public virtual FlowItemList FlowItemList { get; set; }
    }
}
