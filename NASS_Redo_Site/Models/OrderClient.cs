using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class OrderClient
    {
        public int OrderClientId { get; set; }
        public int OrderDetailsId { get; set; }
        public int UserId { get; set; }

        public virtual OrderDetails OrderDetails { get; set; }
        public virtual User User { get; set; }
    }
}
