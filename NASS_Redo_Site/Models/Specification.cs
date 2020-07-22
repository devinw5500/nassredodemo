using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Specification
    {
        public int SpecificationId { get; set; }
        public int SpecListId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }

        public virtual SpecificationList SpecList { get; set; }
    }
}
