using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class SpecificationList
    {
        public SpecificationList()
        {
            Specification = new HashSet<Specification>();
        }

        public int SpecificationListId { get; set; }
        public int OrderDetailsId { get; set; }

        public virtual OrderDetails OrderDetails { get; set; }
        public virtual ICollection<Specification> Specification { get; set; }
    }
}
