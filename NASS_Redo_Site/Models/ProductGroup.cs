using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            ProdInGroup = new HashSet<ProdInGroup>();
        }

        public int ProductGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProdInGroup> ProdInGroup { get; set; }
    }
}
