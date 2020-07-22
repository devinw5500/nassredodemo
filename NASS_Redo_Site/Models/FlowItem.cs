using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class FlowItem
    {
        public FlowItem()
        {
            ItemInList = new HashSet<ItemInList>();
        }

        public int FlowItemId { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
        public bool ClientDescription { get; set; }
        public bool VendorDescription { get; set; }
        public bool DependentFlow { get; set; }
        public bool AllGroup { get; set; }
        public bool DisplayVendorPortal { get; set; }

        public virtual ICollection<ItemInList> ItemInList { get; set; }
    }
}
