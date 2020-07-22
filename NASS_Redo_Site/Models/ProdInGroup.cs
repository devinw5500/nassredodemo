using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ProdInGroup
    {
        public int ProdInGroupId { get; set; }
        public int ProductId { get; set; }
        public int GroupId { get; set; }

        public virtual ProductGroup Group { get; set; }
        public virtual Product Product { get; set; }
    }
}
