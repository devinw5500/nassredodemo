using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class StatusForOrder
    {
        public int StatusForOrderId { get; set; }
        public int StatusId { get; set; }
        public int OrderDetailId { get; set; }

        public virtual OrderDetails OrderDetail { get; set; }
        public virtual OrderStatus Status { get; set; }
    }
}
