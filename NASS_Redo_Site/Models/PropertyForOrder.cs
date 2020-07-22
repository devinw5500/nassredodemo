using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class PropertyForOrder
    {
        public int PropertyForOrder1 { get; set; }
        public int AddressId { get; set; }
        public int OrderDetailsId { get; set; }

        public virtual Address Address { get; set; }
        public virtual OrderDetails OrderDetails { get; set; }
    }
}
